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
using WebDatamaceApi.Interface;

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
        private readonly IBackgroundQueue<MailControle> _queue;


        public MailControlesController(CoreDbContext context, NotificationMetadata notificationMetadata, IBackgroundQueue<MailControle> queue)
        {
            _context = context;
            _notificationMetadata = notificationMetadata;
            _queue = queue;

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
                await EnviarEmail(mailControle);

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
            try
            {
                await EnviarEmail(mailControle);

            }
            catch (Exception)
            {
                throw;
            }

            return CreatedAtAction("GetMailControle", new { id = mailControle.IdControle }, mailControle);
        }


        // POST: api/MailControles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("FaleConosco")]
        [AllowAnonymous]
        public async Task<ActionResult<MailControle>> FaleConosco(FaleConoscoEntity faleConoscoEntity)
        {
            try
            {
                string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
                string to = "datamace@datamace.com.br";   // E-mail do destinatário // datamace@datamace.com.br

                string nome = "Datamace";
                string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
                string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP

                string assunto = "";

                switch (faleConoscoEntity.Assunto)
                {
                    case "aliancas":
                        assunto = "Marketing(Alianças e informações sobre produtos e serviços)";
                        break;

                    case "comercial":
                        assunto = "Comercial(Agendar uma demonstração e modelos de negócio)";
                        break;

                    case "treinamento":
                        assunto = "Treinamento(Para obter mais conhecimento sobre nossas soluções)";
                        break;

                    case "RH":
                        assunto = "Recursos Humanos(Para processos seletivos e oportunidades de emprego)";
                        break;

                    case "administracao":
                        assunto = "Administração(Para assuntos gerais da administração)";
                        break;

                    default:
                        break;
                }

                string conteudo = $"Olá <b>{nome}</b>, recebemos um contato sobre <b>{assunto}</b> de:<br/><br/>" +
                        $"<b>Nome</b>: {faleConoscoEntity.Nome}<br/>" +
                        $"<b>Email</b>: {faleConoscoEntity.Email}<br/>" +
                        $"<b>Telefone</b>: {faleConoscoEntity.Telefone}<br/>" +
                        $"<b>Empresa</b>: {faleConoscoEntity.Empresa}<br/>" +
                        (!string.IsNullOrEmpty(faleConoscoEntity.Qtdefuncionarios) ? $"<b>Funcionáios:</b>: {faleConoscoEntity.Qtdefuncionarios}<br/>" : "") +
                        (!string.IsNullOrEmpty(faleConoscoEntity.cargo) ? $"<b>Cargo</b>: {faleConoscoEntity.cargo}<br/>" : "") +
                        $"<b>Cidade</b>: {faleConoscoEntity.Cidadeselected}<br/>" +
                        $"<b>Estado</b>: {faleConoscoEntity.EstadoSelected}<br/><br/>" +
                        $"<b>Mensagem</b>: {faleConoscoEntity.Info}<br/><br/><br/><br/> Att, Datamace";

                MailMessage message = new MailMessage(from, to, "Fale Conosco - www.datamace.com.br", conteudo);
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port);

                smtp.Credentials = new NetworkCredential(user, pass);
                await smtp.SendMailAsync(message);

            }
            catch (Exception)
            {
                throw;
            }

            return Ok();
        }

        [HttpPost("SejaParceiro")]
        [AllowAnonymous]
        public async Task<ActionResult<MailControle>> SejaParceiro(SejaParceiroEntity sejaParceiroEntity)
        {
            try
            {
                string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
                string to = "datamace@datamace.com.br";   // E-mail do destinatário // datamace@datamace.com.br
                //string to = "gabriel.dassie@hotmail.com";
                string nome = "Datamace";
                string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
                string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP


                string conteudo = $"Olá <b>{nome}</b>, recebemos um pedido de </b>Seja Parceiro</b> de:<br/><br/>" +
                        $"<b>Nome</b>: {sejaParceiroEntity.Nome}<br/>" +
                        $"<b>Email</b>: {sejaParceiroEntity.Email}<br/>" +
                        $"<b>Telefone</b>: {sejaParceiroEntity.Telefone}<br/>" +
                        $"<b>Empresa</b>: {sejaParceiroEntity.Empresa}<br/>" +
                        $"<b>Cidade</b>: {sejaParceiroEntity.Cidadeselected}<br/>" +
                        $"<b>Estado</b>: {sejaParceiroEntity.EstadoSelected}<br/><br/>" +
                        $"<b>Info</b>: {sejaParceiroEntity.Info}<br/><br/><br/><br/> Att, Datamace";

                MailMessage message = new MailMessage(from, to, "Seja Parceiro - www.datamace.com.br", conteudo);
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port);

                smtp.Credentials = new NetworkCredential(user, pass);
                await smtp.SendMailAsync(message);

            }
            catch (Exception)
            {
                throw;
            }

            return Ok();
        }

        private async Task EnviarEmail(MailControle mailControle)
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
                    if (!mailControle.Produto.Equals("16"))
                    {
                        var listUser = _context.TbUsuarios.Where(tBusuarios =>
                        _context.TbUsuariosProdutos.Where(usuariosProdutos => usuariosProdutos.Produto.ToString().Equals(mailControle.Produto.Trim()))
                        .Select(j => j.Usuario).Contains(tBusuarios.Usuario)).Select(us => us.Email);

                        emails += String.Join(";", listUser.ToArray());
                    }
                    else {
                        var listUser = _context.TbUsuarios.Select(us => us.Email).Distinct();

                        emails += String.Join(";", listUser.ToArray());
                    }

                }

                if (!emails.Equals(""))
                {
                    foreach (var email in emails.Split(";"))
                    {
                        mailControle.EmailDestinatario = "gabriel.dassie@hotmail.com";
                        _queue.Enqueue(mailControle);
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
