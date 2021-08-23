using System;
using System.Collections.Generic;
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

            // Recupera o usuário
            var user = userRepository.GetCurUsuarios(model.Email, model.Password);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "E-mail ou senha inválidos" });
            if (!user.Status)
                return Forbid();

            // Gera o Token
            var token = TokenService.GenerateTokenCurUsuario(user);

            var cursos = (from curusuariosturmas in _context.Set<CurUsuariosTurmas>()
                          join curusuarios in _context.Set<CurUsuarios>()
                          on curusuariosturmas.IdUsuario equals curusuarios.IdUsuario
                          join curturmas in _context.Set<CurTurma>()
                          on curusuariosturmas.IdTurma equals curturmas.IdTurma
                          join curtreinamento in _context.Set<CurTreinamento>()
                            on curturmas.IdTreinamento equals curtreinamento.IdTreinamento
                          where curusuariosturmas.IdUsuario == user.IdUsuario
                          select new { curturmas, curtreinamento }).ToList();

            // Oculta a senha
            user.Senha = "";

            // Retorna os dados
            return new
            {
                user = user,
                cursos = cursos,
                token = token
            };
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
