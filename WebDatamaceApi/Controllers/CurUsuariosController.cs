using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDatamaceApi.Models;
using WebDatamaceApi.Models.Entity;

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CurUsuariosController : ControllerBase
    {
        private readonly CoreDbContext _context;
        private readonly NotificationMetadata _notificationMetadata;


        public CurUsuariosController(CoreDbContext context, NotificationMetadata notificationMetadata)
        {
            _context = context;
            _notificationMetadata = notificationMetadata;

        }

        // GET: api/CurUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurUsuarios>>> GetCurUsuarios(int idEmpresa = 0)
        {
            try
            {
                if (idEmpresa == 0)
                {

                    return await _context.CurUsuarios.Select(x => new CurUsuarios
                    {
                        Turmas = _context.CurUsuariosTurmas.Where(e => e.IdUsuario == x.IdUsuario).Count(),
                        IdUsuario = x.IdUsuario,
                        Celular = x.Celular,
                        Cidade = x.Cidade,
                        Cpf = x.Cpf,
                        DataCriacao = x.DataCriacao,
                        Ddd = x.Ddd,
                        Ddd1 = x.Ddd1,
                        DesejaNews = x.DesejaNews,
                        Email = x.Email,
                        Funcao = x.Funcao,
                        IdEmpresa = x.IdEmpresa,
                        Nome = x.Nome,
                        Origem = x.Origem,
                        Rg = x.Rg,
                        Senha = x.Senha,
                        Status = x.Status,
                        Telefone = x.Telefone,
                        NomeEmpresa = _context.TbEmpresas.Where(emp => emp.Empresa == x.IdEmpresa).FirstOrDefault().Nome,
                        Estado = x.Estado,
                        ListaTreinamentos = new List<string>(),
                        ListaTurmas = new List<CurTurmaUsuarioEntity>()
                        //ListaTurmas = (from turma in _context.Set<CurTurma>()
                        //               join grupo in _context.Set<CurTurmaGrupo>()
                        //                on turma.IdGrupo equals grupo.IdGrupo
                        //               join usetTurma in _context.Set<CurUsuariosTurmas>()
                        //               on turma.IdTurma equals usetTurma.IdTurma
                        //               join treinamento in _context.Set<CurTreinamento>()
                        //              on turma.IdTreinamento equals treinamento.IdTreinamento
                        //               where usetTurma.IdUsuario == x.IdUsuario
                        //               orderby grupo.NomeGrupo ascending
                        //               select new CurTurmaUsuarioEntity
                        //               {
                        //                   turma = turma,
                        //                   grupo = grupo,
                        //                   treinamento = treinamento,

                        //                   inscritos =
                        //               _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                        //               }).ToList()
                        //ListaTreinamentos = _context.CurTreinamento.Where(CurTrein =>
                        //   _context.CurTurma.Where(curturm =>
                        //   _context.CurUsuariosTurmas.Where(curusu => curusu.IdUsuario == x.IdUsuario)
                        //   .Select(g => g.IdTurma).Contains(curturm.IdTurma)).Select(fg => fg.IdTreinamento).Contains(CurTrein.IdTreinamento)).Select(cur => cur.Nome)
                        //    .ToList()

                    }
                                )
                                    .ToListAsync();
                }
                else
                {
                    return await _context.CurUsuarios.Where(x => x.IdEmpresa == idEmpresa).Select(x => new CurUsuarios
                    {
                        Turmas = _context.CurUsuariosTurmas.Where(e => e.IdUsuario == x.IdUsuario).Count(),
                        IdUsuario = x.IdUsuario,
                        Celular = x.Celular,
                        Cidade = x.Cidade,
                        Cpf = x.Cpf,
                        DataCriacao = x.DataCriacao,
                        Ddd = x.Ddd,
                        Ddd1 = x.Ddd1,
                        DesejaNews = x.DesejaNews,
                        Email = x.Email,
                        Funcao = x.Funcao,
                        IdEmpresa = x.IdEmpresa,
                        Nome = x.Nome,
                        Origem = x.Origem,
                        Rg = x.Rg,
                        Senha = x.Senha,
                        Status = x.Status,
                        Telefone = x.Telefone,
                        NomeEmpresa = _context.TbEmpresas.Where(emp => emp.Empresa == x.IdEmpresa).FirstOrDefault().Nome,
                        Estado = x.Estado,
                        ListaTreinamentos = new List<string>(),
                        ListaTurmas = (from turma in _context.Set<CurTurma>()
                                       join grupo in _context.Set<CurTurmaGrupo>()
                                        on turma.IdGrupo equals grupo.IdGrupo
                                       join usetTurma in _context.Set<CurUsuariosTurmas>()
                                       on turma.IdTurma equals usetTurma.IdTurma
                                       join treinamento in _context.Set<CurTreinamento>()
                                       on turma.IdTreinamento equals treinamento.IdTreinamento
                                       where usetTurma.IdUsuario == x.IdUsuario
                                       orderby grupo.NomeGrupo ascending
                                       select new CurTurmaUsuarioEntity
                                       {
                                           turma = turma,
                                           grupo = grupo,
                                           treinamento = treinamento,
                                           inscritos =
                                       _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                                       }).ToList()
                        //ListaTreinamentos = _context.CurTreinamento.Where(CurTrein =>
                        //   _context.CurTurma.Where(curturm =>
                        //   _context.CurUsuariosTurmas.Where(curusu => curusu.IdUsuario == x.IdUsuario)
                        //   .Select(g => g.IdTurma).Contains(curturm.IdTurma)).Select(fg => fg.IdTreinamento).Contains(CurTrein.IdTreinamento)).Select(cur => cur.Nome)
                        //     .ToList()
                    }
                                    )
                                        .ToListAsync();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpGet("GetTurmas")]
        public async Task<ActionResult<IEnumerable<CurTurmaUsuarioEntity>>> GetTurmas(int idUsuario = 0)
        {

            if (idUsuario == 0)
            {
                return new List<CurTurmaUsuarioEntity>();
            }
            try
            {
                return await (from turma in _context.Set<CurTurma>()
                              join grupo in _context.Set<CurTurmaGrupo>()
                               on turma.IdGrupo equals grupo.IdGrupo
                              join usetTurma in _context.Set<CurUsuariosTurmas>()
                              on turma.IdTurma equals usetTurma.IdTurma
                              join treinamento in _context.Set<CurTreinamento>()
                             on turma.IdTreinamento equals treinamento.IdTreinamento
                              where usetTurma.IdUsuario == idUsuario
                              orderby grupo.NomeGrupo ascending
                              select new CurTurmaUsuarioEntity
                              {
                                  turma = turma,
                                  grupo = grupo,
                                  treinamento = treinamento,

                                  inscritos =
                          _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                              }).ToListAsync();

            }
            catch (Exception e)
            {
                return new List<CurTurmaUsuarioEntity>();
            }
        }




        // GET: api/CurUsuarios
        [HttpGet("GetByTurma")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetByTurma(int idTurma = 0)
        {
            if (idTurma == 0)
            {
                return BadRequest();
            }
            else
            {
                return await _context.CurUsuarios.Where(x => _context.CurUsuariosTurmas.Where(p => p.IdTurma == idTurma).Select(hj => hj.IdUsuario).Contains(x.IdUsuario))
                    .Select(x => new
                    {
                        Turmas = _context.CurUsuariosTurmas.Where(e => e.IdUsuario == x.IdUsuario).Count(),
                        IdUsuario = x.IdUsuario,
                        Celular = x.Celular,
                        Cidade = x.Cidade,
                        Cpf = x.Cpf,
                        DataCriacao = x.DataCriacao,
                        Ddd = x.Ddd,
                        Ddd1 = x.Ddd1,
                        DesejaNews = x.DesejaNews,
                        Email = x.Email,
                        Funcao = x.Funcao,
                        IdEmpresa = x.IdEmpresa,
                        Nome = x.Nome,
                        Origem = x.Origem,
                        Rg = x.Rg,
                        Senha = x.Senha,
                        Status = x.Status,
                        Telefone = x.Telefone,
                        NomeEmpresa = _context.TbEmpresas.Where(emp => emp.Empresa == x.IdEmpresa).FirstOrDefault().Nome,
                        Estado = x.Estado,
                        CurUsuariosTurmas = _context.CurUsuariosTurmas.Where(xt => xt.IdTurma == idTurma && xt.IdUsuario == x.IdUsuario).FirstOrDefault(),
                        ListaTreinamentos = new List<string>(),
                        ListaTurmas = (from turma in _context.Set<CurTurma>()
                                       join grupo in _context.Set<CurTurmaGrupo>()
                                        on turma.IdGrupo equals grupo.IdGrupo
                                       join usetTurma in _context.Set<CurUsuariosTurmas>()
                                       on turma.IdTurma equals usetTurma.IdTurma
                                       join treinamento in _context.Set<CurTreinamento>()
                                      on turma.IdTreinamento equals treinamento.IdTreinamento
                                       where usetTurma.IdUsuario == x.IdUsuario
                                       orderby grupo.NomeGrupo ascending
                                       select new CurTurmaUsuarioEntity
                                       {
                                           turma = turma,
                                           grupo = grupo,
                                           treinamento = treinamento,
                                           inscritos =
                                       _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                                       }).ToList()
                    }
                                )
                                    .ToListAsync();
            }
        }


        // GET: api/CurUsuarios
        [HttpGet("GetByTreinamento")]
        public async Task<ActionResult<IEnumerable<CurUsuarios>>> GetByTreinamento(int idTreinamento = 0)
        {
            if (idTreinamento == 0)
            {
                return BadRequest();
            }
            else
            {

                List<int> ids = _context.CurTurma.Where(x => x.IdTreinamento == idTreinamento).Select(u => u.IdTurma).ToList();

                if (ids == null)
                {
                    return new List<CurUsuarios>();
                }

                return await _context.CurUsuarios.Where(x => _context.CurUsuariosTurmas.Where(p => ids.Contains(p.IdTurma))
                .Select(hj => hj.IdUsuario).Contains(x.IdUsuario))
                    .Select(x => new CurUsuarios
                    {
                        Turmas = _context.CurUsuariosTurmas.Where(e => e.IdUsuario == x.IdUsuario).Count(),
                        IdUsuario = x.IdUsuario,
                        Celular = x.Celular,
                        Cidade = x.Cidade,
                        Cpf = x.Cpf,
                        DataCriacao = x.DataCriacao,
                        Ddd = x.Ddd,
                        Ddd1 = x.Ddd1,
                        DesejaNews = x.DesejaNews,
                        Email = x.Email,
                        Funcao = x.Funcao,
                        IdEmpresa = x.IdEmpresa,
                        Nome = x.Nome,
                        Origem = x.Origem,
                        Rg = x.Rg,
                        Senha = x.Senha,
                        Status = x.Status,
                        Telefone = x.Telefone,
                        NomeEmpresa = _context.TbEmpresas.Where(emp => emp.Empresa == x.IdEmpresa).FirstOrDefault().Nome,
                        Estado = x.Estado,
                        ListaTreinamentos = new List<string>(),
                        ListaTurmas = (from turma in _context.Set<CurTurma>()
                                       join grupo in _context.Set<CurTurmaGrupo>()
                                        on turma.IdGrupo equals grupo.IdGrupo
                                       join usetTurma in _context.Set<CurUsuariosTurmas>()
                                       on turma.IdTurma equals usetTurma.IdTurma
                                       join treinamento in _context.Set<CurTreinamento>()
                                      on turma.IdTreinamento equals treinamento.IdTreinamento
                                       where usetTurma.IdUsuario == x.IdUsuario
                                       orderby grupo.NomeGrupo ascending
                                       select new CurTurmaUsuarioEntity
                                       {
                                           turma = turma,
                                           grupo = grupo,
                                           treinamento = treinamento,
                                           inscritos =
                                       _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                                       }).ToList()



                        //ListaTreinamentos = _context.CurTreinamento.Where(CurTrein =>
                        //   _context.CurTurma.Where(curturm =>
                        //   _context.CurUsuariosTurmas.Where(curusu => curusu.IdUsuario == x.IdUsuario)
                        //   .Select(g => g.IdTurma).Contains(curturm.IdTurma)).Select(fg => fg.IdTreinamento).Contains(CurTrein.IdTreinamento)).Select(cur => cur.Nome)
                        // .ToList()
                    }
                                )
                                    .ToListAsync();
            }
        }
        //// GET: api/CurUsuarios/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CurUsuarios>> GetCurUsuarios(int id)
        //{
        //    var curUsuarios = await _context.CurUsuarios.FindAsync(id);

        //    if (curUsuarios == null)
        //    {
        //        return NotFound();
        //    }

        //    return curUsuarios;
        //}
        [HttpPut("UpdateSenha")]

        public async Task<IActionResult> UpdateSenha(int id, UpdatePwd pwd)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            CurUsuarios curUsuarios = _context.CurUsuarios.Where(e => e.IdUsuario == id).FirstOrDefault();
            if (curUsuarios == null)
            {
                return NotFound();
            }

            if (curUsuarios.Senha.Equals(CreateMD5(pwd.senha)))
            {
                if (pwd.novasenha.Equals(pwd.confirmacaosenha))
                {
                    curUsuarios.Senha = CreateMD5(pwd.novasenha);

                    try
                    {
                        _context.Entry(curUsuarios).State = EntityState.Modified;

                        await _context.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CurUsuariosExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return NoContent();

                }
                else
                {
                    return BadRequest("Senhas não conferem.");
                }
            }
            else
            {
                return BadRequest("Antiga senha inválida.");
            }

        }

        private static string CreateMD5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // PUT: api/CurUsuarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurUsuarios(int id, CurUsuarioEntity curUsuarioEntity, bool presente = false, bool pago = false, bool confirmado = false, string resultado = "", string obs = "", bool isUpdateTurma = false)
        {
            if (curUsuarioEntity == null &&
                id != curUsuarioEntity.IdUsuario
                && String.IsNullOrEmpty(curUsuarioEntity.Cpf)
               && String.IsNullOrEmpty(curUsuarioEntity.Rg)
               && String.IsNullOrEmpty(curUsuarioEntity.Nome)
               && String.IsNullOrEmpty(curUsuarioEntity.Email))
            {
                return BadRequest();
            }

            CurUsuarios curUsuarios = _context.CurUsuarios.Where(e => e.IdUsuario == curUsuarioEntity.IdUsuario).FirstOrDefault();
            if (curUsuarios == null)
            {
                return NotFound();
            }

            string numero = "";
            if (!string.IsNullOrEmpty(curUsuarioEntity.Telefone))
            {
                numero = CleanPhone(curUsuarioEntity.Telefone);

            }

            string ddd = "";
            if (!string.IsNullOrEmpty(curUsuarioEntity.Telefone) && Regex.Match(curUsuarioEntity.Telefone, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
            {
                // Remove qualquer caracter que não seja numérico
                numero = CleanPhone(curUsuarioEntity.Telefone);
                // Pega os 2 primeiros caracteres
                ddd = numero.Substring(0, 2);
                numero = numero.Substring(2, numero.Length - 2);

            }

            string celular = "";
            if (!string.IsNullOrEmpty(curUsuarioEntity.Celular))
            {
                celular = CleanPhone(curUsuarioEntity.Celular);
            }

            string ddd1 = "";
            if (!string.IsNullOrEmpty(curUsuarioEntity.Celular) && Regex.Match(curUsuarioEntity.Celular, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
            {
                // Remove qualquer caracter que não seja numérico
                celular = CleanPhone(curUsuarioEntity.Celular);
                // Pega os 2 primeiros caracteres
                ddd1 = celular.Substring(0, 2);
                celular = celular.Substring(2, celular.Length - 2);

            }


            curUsuarios.Email = curUsuarioEntity.Email;
            curUsuarios.Nome = curUsuarioEntity.Nome;
            curUsuarios.Origem = curUsuarioEntity.Origem;
            curUsuarios.Senha = curUsuarioEntity.Senha;
            curUsuarios.Status = curUsuarioEntity.Status;
            curUsuarios.Telefone = numero;
            curUsuarios.Ddd = ddd;
            curUsuarios.Celular = celular;
            curUsuarios.Ddd1 = ddd1;
            curUsuarios.Cpf = curUsuarioEntity.Cpf;
            curUsuarios.Rg = curUsuarioEntity.Rg;
            curUsuarios.IdEmpresa = curUsuarioEntity.IdEmpresa;
            curUsuarios.Funcao = curUsuarioEntity.Funcao;
            curUsuarios.Cidade = curUsuarioEntity.Cidade;
            curUsuarios.DesejaNews = curUsuarioEntity.DesejaNews;
            curUsuarios.Estado = curUsuarioEntity.Estado;

            try
            {

                _context.Entry(curUsuarios).State = EntityState.Modified;


                await _context.SaveChangesAsync();

                if (curUsuarioEntity.IdTurma != null && curUsuarioEntity.IdTurma > 0 && isUpdateTurma)
                {
                    CurUsuariosTurmas curUsuariosTurmas = _context.CurUsuariosTurmas.Where(x => x.IdTurma == curUsuarioEntity.IdTurma && x.IdUsuario == curUsuarioEntity.IdUsuario).FirstOrDefault();
                    if (curUsuariosTurmas != null)
                    {
                        curUsuariosTurmas.Aprovado = confirmado;
                        curUsuariosTurmas.Obs = obs;
                        curUsuariosTurmas.Pago = pago;
                        curUsuariosTurmas.Presente = presente;
                        curUsuariosTurmas.Resultado = resultado;

                        _context.Entry(curUsuariosTurmas).State = EntityState.Modified;

                        await _context.SaveChangesAsync();
                    }
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurUsuariosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private static Regex digitsOnly = new Regex(@"[^\d]");

        public static string CleanPhone(string phone)
        {
            return digitsOnly.Replace(phone, "");
        }

        // POST: api/CurUsuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurUsuarios>> PostCurUsuarios(CurUsuarioEntity curUsuarioEntity, bool presente = false, bool pago = false, bool confirmado = false, string resultado = "", string obs = "")
        {
            if (curUsuarioEntity == null
                && String.IsNullOrEmpty(curUsuarioEntity.Cpf)
               && String.IsNullOrEmpty(curUsuarioEntity.Rg)
               && String.IsNullOrEmpty(curUsuarioEntity.Nome)
               && String.IsNullOrEmpty(curUsuarioEntity.Email))
            {
                return BadRequest();
            }

            string numero = "";
            string ddd = "";
            if (Regex.Match(curUsuarioEntity.Telefone, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
            {
                // Remove qualquer caracter que não seja numérico
                numero = CleanPhone(curUsuarioEntity.Telefone);
                // Pega os 2 primeiros caracteres
                ddd = numero.Substring(0, 2);
                numero = numero.Substring(2, numero.Length - 2);

            }

            string celular = "";
            string ddd1 = "";
            if (Regex.Match(curUsuarioEntity.Celular, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
            {
                // Remove qualquer caracter que não seja numérico
                celular = CleanPhone(curUsuarioEntity.Celular);
                // Pega os 2 primeiros caracteres
                ddd1 = celular.Substring(0, 2);
                celular = celular.Substring(2, celular.Length - 2);

            }


            CurUsuarios curUsuarios = new CurUsuarios()
            {
                IdUsuario = 0,
                DataCriacao = DateTime.Now,
                Estado = curUsuarioEntity.Estado,
                Celular = celular,
                Cpf = curUsuarioEntity.Cpf,
                Ddd = ddd,
                Ddd1 = ddd1,
                Cidade = curUsuarioEntity.Cidade,
                Email = curUsuarioEntity.Email,
                DesejaNews = curUsuarioEntity.DesejaNews,
                IdEmpresa = curUsuarioEntity.IdEmpresa,
                Funcao = curUsuarioEntity.Funcao,
                Nome = curUsuarioEntity.Nome,
                Origem = curUsuarioEntity.Origem,
                Rg = curUsuarioEntity.Rg,
                Senha = curUsuarioEntity.Senha,
                Status = curUsuarioEntity.Status,
                Telefone = numero
            };

            string senha = GerarSenha();
            curUsuarios.Senha = CreateMD5(senha);

            try
            {

                _context.CurUsuarios.Add(curUsuarios);
                await _context.SaveChangesAsync();

                try
                {
                    string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
                    string to = curUsuarioEntity.Email;   // E-mail do destinatário // datamace@datamace.com.br

                    string nome = curUsuarioEntity.Nome;
                    string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
                    string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP

                    string conteudo = $"Olá <b>{curUsuarioEntity.Nome}</b>, segue seus dados para acesso a <a href='https://www.datamace.com.br/'>Datamace</a>:<br/><br/>" +
                     $"<b>Nome</b>: {curUsuarioEntity.Nome}<br/>" +
                     $"<b>Email</b>: {curUsuarioEntity.Email}<br/>" +
                     $"<b>Senha</b>: {senha}<br/>";

                    //string template = "informe_on_site.html";
                    string template = "sem_template.bmp";


                    if (!template.Equals("sem_template.bmp"))
                    {
                        using (var sr = new StreamReader("templates/" + template.Replace(".bmp", ".html")))
                        {
                            // Read the stream as a string, and write the string to the console.
                            string templateHtml = sr.ReadToEnd();
                            if (!String.IsNullOrEmpty(templateHtml))
                            {

                                conteudo = templateHtml.Replace("{texto_noticia}", conteudo);
                            }
                        }
                    }

                    MailMessage message = new MailMessage(from, to, "Datamace - Dados de acesso", conteudo);
                    message.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port);

                    smtp.Credentials = new NetworkCredential(user, pass);
                    await smtp.SendMailAsync(message);

                }
                catch (Exception) { }

                if (curUsuarioEntity.IdTurma != null && curUsuarioEntity.IdTurma > 0)
                {
                    CurUsuariosTurmas curUsuariosTurmas = new CurUsuariosTurmas()
                    {
                        IdTurma = (int)curUsuarioEntity.IdTurma,
                        IdUsuario = curUsuarios.IdUsuario,
                        Aprovado = confirmado,
                        DataCriacao = DateTime.Now,
                        Obs = obs,
                        Pago = pago,
                        Presente = presente,
                        Resultado = resultado
                    };
                    _context.CurUsuariosTurmas.Add(curUsuariosTurmas);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return CreatedAtAction("GetCurUsuarios", new { id = curUsuarios.IdUsuario }, curUsuarios);
        }

        private string GerarSenha()
        {
            // Gera uma senha com 6 caracteres entre numeros e letras
            string chars = "abcdefghjkmnpqrstuvwxyz023456789";
            string pass = "";
            Random random = new Random();
            for (int f = 0; f < 6; f++)
            {
                pass = pass + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }
            return pass;
        }


        // PUT: api/CurUsuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("UpdateTurma")]
        public async Task<ActionResult<CurUsuarios>> UpdateTurma(int idUser, int idTurma, bool add)
        {
            CurUsuarios curUsuarios = _context.CurUsuarios.Where(e => e.IdUsuario == idUser).FirstOrDefault();
            if (curUsuarios == null)
            {
                return NotFound();
            }


            CurTurma curTurma = _context.CurTurma.Where(e => e.IdTurma == idTurma).FirstOrDefault();
            if (curUsuarios == null)
            {
                return NotFound();
            }

            try
            {
                CurUsuariosTurmas curUsuariosTurmas = _context.CurUsuariosTurmas
                        .Where(e => e.IdTurma == idTurma && e.IdUsuario == idUser).FirstOrDefault();

                if (add)
                {


                    if (curUsuariosTurmas == null)
                    {
                        curUsuariosTurmas = new CurUsuariosTurmas()
                        {
                            IdTurma = (int)curTurma.IdTurma,
                            IdUsuario = curUsuarios.IdUsuario,
                            Aprovado = false,
                            DataCriacao = DateTime.Now,
                            Obs = "",
                            Pago = false,
                            Presente = false,
                            Resultado = ""
                        };
                        _context.CurUsuariosTurmas.Add(curUsuariosTurmas);
                        await _context.SaveChangesAsync();
                    }
                }
                else
                {

                    if (curUsuariosTurmas == null)
                    {
                        return NotFound();
                    }
                    _context.CurUsuariosTurmas.Remove(curUsuariosTurmas);
                    await _context.SaveChangesAsync();

                }
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // DELETE: api/CurUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurUsuarios>> DeleteCurUsuarios(int id)
        {
            var curUsuarios = await _context.CurUsuarios.FindAsync(id);
            if (curUsuarios == null)
            {
                return NotFound();
            }

            _context.CurUsuarios.Remove(curUsuarios);
            await _context.SaveChangesAsync();

            return curUsuarios;
        }

        private bool CurUsuariosExists(int id)
        {
            return _context.CurUsuarios.Any(e => e.IdUsuario == id);
        }
    }
}
