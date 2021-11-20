using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDatamaceApi.Models;
using WebDatamaceApi.Models.Entity;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class MailControlesController : ControllerBase
    {
        private readonly CoreDbContext _context;
        private readonly NotificationMetadata _notificationMetadata;

        public MailControlesController(CoreDbContext context, NotificationMetadata notificationMetadata)
        {
            _context = context;
            _notificationMetadata = notificationMetadata;
        }

        // GET: api/MailControles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MailControle>>> GetMailControle()
        {
            return await _context.MailControle.ToListAsync();
        }


        [HttpGet("GetMailControleTreinamento")]
        public async Task<ActionResult<IEnumerable<MailControleEntity>>> GetMailControleTreinamento()
        {
            var total = _context.MailControle.Count();

            return await _context.MailControle.Where(o => o.Produto != null).GroupBy(x => x.Produto).Select(x => new MailControleEntity
            {
                Nome = _context.TbProdutos.Where(pd => pd.Produto.ToString().Equals(x.Key)).FirstOrDefault().Nome,
                controle = x.Key,
                qtde = x.Count(),
                porcentagem = (x.Count() == 0) ? "0.00%" : (Math.Round(((decimal)(Math.Round((((decimal)x.Count()) / ((decimal)total)), 2) * 100)), 2).ToString("n2") + "%")
            }).ToListAsync();
        }

        private static string GetNomeProduto(TbProdutos tbProdutos)
        {
            if (tbProdutos != null)
            {
                return tbProdutos.Nome;
            }
            return "";
        }

        [HttpGet("GetMailControleTemplate")]
        public async Task<ActionResult<IEnumerable<MailControleEntity>>> GetMailControleTemplate()
        {
            var total = _context.MailControle.Count();

            return await _context.MailControle.Where(o => o.Template != null).GroupBy(n => n.Template).Select(x => new MailControleEntity
            {
                Nome = x.Key,
                qtde = x.Count(),
                porcentagem = (x.Count() == 0) ? "0.00%" : (Math.Round(((decimal)(((decimal)x.Count() / (decimal)total) * 100)), 2).ToString("n2") + "%")
            }).ToListAsync();
        }


        [HttpGet("GetRascunhos")]
        public async Task<ActionResult<IEnumerable<MailControle>>> MailControle()
        {
            return await _context.MailControle.Where(o => o.Enviado == "0").ToListAsync();
        }

        // GET: api/MailControles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MailControle>> GetMailControle(int id)
        {
            var mailControle = await _context.MailControle.FindAsync(id);

            if (mailControle == null)
            {
                return NotFound();
            }

            return mailControle;
        }

        // PUT: api/MailControles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMailControle(int id, MailControle mailControle)
        {
            if (id != mailControle.IdControle)
            {
                return BadRequest();
            }

            _context.Entry(mailControle).State = EntityState.Modified;

            try
            {
                EnviarEmail(mailControle);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MailControleExists(id))
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

        // POST: api/MailControles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MailControle>> PostMailControle(MailControle mailControle)
        {
            _context.MailControle.Add(mailControle);
            try
            {
                EnviarEmail(mailControle);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MailControleExists(mailControle.IdControle))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMailControle", new { id = mailControle.IdControle }, mailControle);
        }

        private void EnviarEmail(MailControle mailControle)
        {
            string emails = "";
            if (mailControle.Enviado == "1")
            {
                if (!string.IsNullOrEmpty(mailControle.Curso) && mailControle.Curso != "0")
                {
                    var listUser = _context.CurUsuarios.Where(usuarios =>
                    _context.CurUsuariosTurmas.Where(usuariosturmas =>
                        _context.CurTurma.Where(turma => turma.IdTreinamento.ToString() == mailControle.Curso)
                            .Select(tp => tp.IdTurma).Contains(usuariosturmas.IdTurma))
                        .Select(j => j.IdUsuario).Contains(usuarios.IdUsuario)).Select(us => us.Email);
                    emails += String.Join(";", listUser.ToArray());

                }

                if (!emails.Equals(""))
                {
                    emails += ";";
                }
                if (!string.IsNullOrEmpty(mailControle.Produto) && mailControle.Produto != "0")
                {
                    var listUser = _context.TbUsuarios.Where(tBusuarios =>
                    _context.TbUsuariosProdutos.Where(usuariosProdutos => usuariosProdutos.Produto.ToString() == mailControle.Produto)
                    .Select(j => j.Usuario).Contains(tBusuarios.Usuario)).Select(us => us.Email);

                    emails += String.Join(";", listUser.ToArray());

                }

                if (!emails.Equals(""))
                {
                    mailControle.EmailDestinatario = emails;


                    string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
                    string to = mailControle.EmailDestinatario;   // E-mail do destinatário
                    string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
                    string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP
                    string conteudo = mailControle.Conteudo;
                    if (!mailControle.Template.Equals("sem_template.bmp")) {

                        using (var sr = new StreamReader("templates/"+mailControle.Template.Replace(".bmp",".html")))
                        {
                            // Read the stream as a string, and write the string to the console.
                            string templateHtml = sr.ReadToEnd();
                            if (!String.IsNullOrEmpty(templateHtml))
                            {

                                conteudo = templateHtml.Replace("{texto_noticia}", conteudo);
                            }
                        }
                    }



                    MailMessage message = new MailMessage(from, to, mailControle.Tema, conteudo);
                    message.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port))
                    {
                        smtp.Credentials = new NetworkCredential(user, pass);
                        smtp.Send(message);
                    }


                }
            }
        }

 

        // DELETE: api/MailControles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MailControle>> DeleteMailControle(int id)
        {
            var mailControle = await _context.MailControle.FindAsync(id);
            if (mailControle == null)
            {
                return NotFound();
            }

            _context.MailControle.Remove(mailControle);
            await _context.SaveChangesAsync();

            return mailControle;
        }

        private bool MailControleExists(int id)
        {
            return _context.MailControle.Any(e => e.IdControle == id);
        }
    }
}
