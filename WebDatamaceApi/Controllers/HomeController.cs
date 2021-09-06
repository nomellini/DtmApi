using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebDatamaceApi.Models;
using WebDatamaceApi.Repositories;
using WebDatamaceApi.Services;

namespace WebDatamaceApi.Controllers
{
    [Route("v1/account")]
    [Produces("application/json")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly CoreDbContext _context;

        public HomeController(CoreDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] Users model)
        {
            UserRepository userRepository = new UserRepository(_context);

            // Recupera o usuário
            var user = userRepository.Get(model.Email, model.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "E-mail ou senha inválidos" });
            if (user.Bloqueado)
                return Forbid();

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Senha = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }



        [HttpPost]
        [Route("authenticateusers")]
        public ActionResult<dynamic> AuthenticateUsers([FromBody] Users model)
        {
            UserRepository userRepository = new UserRepository(_context);
            LogRepository logRepository = new LogRepository(_context);

            // Recupera o usuário
            var user = userRepository.GetCurUsuarios(model.Email, model.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "E-mail ou senha inválidos" });
            if (!user.Status)
                return Forbid();

            logRepository.InserLog(user.IdUsuario, "Acessou a conta");
            // Gera o Token
            var token = TokenService.GenerateTokenCurUsuario(user);

            var listCurUsuariosLog = _context.CurUsuariosLog.Where(k => k.CurUsuariosIdUsuario == user.IdUsuario).ToList();

            var logs = listCurUsuariosLog.GroupBy(o => o.DataLog.AddHours(-3).Date).OrderBy(i=> i.Key)
                              .Select(f => new
                              {
                                  DataForma = UppercaseFirst(f.Key.ToString("D", CultureInfo.CreateSpecificCulture("pt-BR"))),
                                  DataLogs = f.Select(r => new
                                  {
                                      Hora = (r.DataLog.AddHours(-3)).Hour.ToString("D2") + ":" + (r.DataLog.AddHours(-3)).Minute.ToString("D2"),
                                      Texto = r.Log
                                  })
                              }).ToList();

            var cursos = (from curusuariosturmas in _context.Set<CurUsuariosTurmas>()
                          join curusuarios in _context.Set<CurUsuarios>()
                          on curusuariosturmas.IdUsuario equals curusuarios.IdUsuario
                          join curturmas in _context.Set<CurTurma>()
                          on curusuariosturmas.IdTurma equals curturmas.IdTurma
                          join curtreinamento in _context.Set<CurTreinamento>()
                            on curturmas.IdTreinamento equals curtreinamento.IdTreinamento
                          where curusuariosturmas.IdUsuario == user.IdUsuario
                          select new
                          {
                              curturmas,
                              curtreinamento,
                              curusuariosturmas
                          }).ToList();

            // Oculta a senha
            user.Senha = "";

            // Retorna os dados
            return new
            {
                user = user,
                cursos = cursos,
                logs = logs,
                token = token
            };
        }

        private string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }


        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}
