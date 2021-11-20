using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
    public class TbTransferenciaArquivosController : ControllerBase
    {
        private readonly CoreDbContext _context;
        public static IHostingEnvironment _environment;
        private readonly NotificationMetadata _notificationMetadata;


        public TbTransferenciaArquivosController(CoreDbContext context, IHostingEnvironment environment, NotificationMetadata notificationMetadata)
        {
            _context = context;
            _environment = environment;
            _notificationMetadata = notificationMetadata;


        }

        // GET: api/TbTransferenciaArquivos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbTransferenciaArquivos>>> GetTbTransferenciaArquivos()
        {
            return await _context.TbTransferenciaArquivos.ToListAsync();
        }

        [HttpGet("Recebidos")]
        public async Task<ActionResult<IEnumerable<TbTransferenciaArquivos>>> GetRecebidos()
        {

            var query = from tbTransferenciaArquivos in _context.Set<TbTransferenciaArquivos>()
                        join tbempresa in _context.Set<TbEmpresas>()
                        on tbTransferenciaArquivos.idEmpresa equals tbempresa.Empresa into juncao1
                        from tbTransferenciaArquivos1 in juncao1.DefaultIfEmpty()
                        join tbProdutos in _context.Set<TbProdutos>()
                        on tbTransferenciaArquivos.Produto equals tbProdutos.Produto into juncao2
                        from tbTransferenciaArquivos2 in juncao2.DefaultIfEmpty()
                        join tbUsuarios in _context.Set<TbUsuarios>()
                        on tbTransferenciaArquivos.idUsuario equals tbUsuarios.Usuario into juncao3
                        from tbTransferenciaArquivos3 in juncao3.DefaultIfEmpty()
                        where tbTransferenciaArquivos.Destinatario == null
                        select new TbTransferenciaArquivos
                        {
                            Transferencia = tbTransferenciaArquivos.Transferencia,
                            Remetente = tbTransferenciaArquivos.Remetente,
                            Destinatario = tbTransferenciaArquivos.Destinatario,
                            Para = tbTransferenciaArquivos.Para,
                            Email = tbTransferenciaArquivos.Email,
                            Assunto = tbTransferenciaArquivos.Assunto,
                            Comentarios = tbTransferenciaArquivos.Comentarios,
                            Arquivo = tbTransferenciaArquivos.Arquivo,
                            Produto = tbTransferenciaArquivos.Produto,
                            idEmpresa = tbTransferenciaArquivos.idEmpresa,
                            idUsuario = tbTransferenciaArquivos.idUsuario,
                            nomeEmpresa = tbTransferenciaArquivos1.Nome,
                            nomeProduto = tbTransferenciaArquivos2.Nome,
                            nomeUsuario = tbTransferenciaArquivos3.Nome,
                            DataEnvioFormat = tbTransferenciaArquivos.Dataenvio.ToString("dd/MM/yyyy"),
                            Dataenvio = tbTransferenciaArquivos.Dataenvio,
                            Status = tbTransferenciaArquivos.Status
                        };
            return await query.ToListAsync();

            //List<TbTransferenciaArquivos> tbTransferenciaArquivos = await _context.TbTransferenciaArquivos.Where(x => x.Destinatario == null).ToListAsync();


            //tbTransferenciaArquivos.All(c =>
            //{
            //    c.nomeEmpresa = c.idEmpresa == null ? "" : _context.CurEmpresas.Where(x => x.IdEmpresa == c.idEmpresa).FirstOrDefault()?.Nome;
            //    c.nomeProduto = c.Produto == null ? "" : _context.TbProdutos.Where(x => x.Produto == c.Produto).FirstOrDefault()?.Nome;
            //    c.nomeUsuario = c.idUsuario == null ? "" : _context.TbUsuarios.Where(x => x.Usuario == c.idUsuario).FirstOrDefault()?.Nome;
            //    return true;
            //});

            //return tbTransferenciaArquivos;
        }


        [HttpGet("Enviados")]
        public async Task<ActionResult<IEnumerable<TbTransferenciaArquivos>>> GetEnviados()
        {


            var query = from tbTransferenciaArquivos in _context.Set<TbTransferenciaArquivos>()
                        join tbempresa in _context.Set<TbEmpresas>()
                        on tbTransferenciaArquivos.idEmpresa equals tbempresa.Empresa into juncao1
                        from tbTransferenciaArquivos1 in juncao1.DefaultIfEmpty()
                        join tbProdutos in _context.Set<TbProdutos>()
                        on tbTransferenciaArquivos.Produto equals tbProdutos.Produto into juncao2
                        from tbTransferenciaArquivos2 in juncao2.DefaultIfEmpty()
                        join tbUsuarios in _context.Set<TbUsuarios>()
                        on tbTransferenciaArquivos.idUsuario equals tbUsuarios.Usuario into juncao3
                        from tbTransferenciaArquivos3 in juncao3.DefaultIfEmpty()
                        where tbTransferenciaArquivos.Remetente == null
                        select new TbTransferenciaArquivos
                        {
                            Transferencia = tbTransferenciaArquivos.Transferencia,
                            Remetente = tbTransferenciaArquivos.Remetente,
                            Destinatario = tbTransferenciaArquivos.Destinatario,
                            Para = tbTransferenciaArquivos.Para,
                            Email = tbTransferenciaArquivos.Email,
                            Assunto = tbTransferenciaArquivos.Assunto,
                            Comentarios = tbTransferenciaArquivos.Comentarios,
                            Arquivo = tbTransferenciaArquivos.Arquivo,
                            Produto = tbTransferenciaArquivos.Produto,
                            idEmpresa = tbTransferenciaArquivos.idEmpresa,
                            idUsuario = tbTransferenciaArquivos.idUsuario,
                            nomeEmpresa = tbTransferenciaArquivos1.Nome,
                            nomeProduto = tbTransferenciaArquivos2.Nome,
                            nomeUsuario = tbTransferenciaArquivos3.Nome,
                            DataEnvioFormat = tbTransferenciaArquivos.Dataenvio.ToString("dd/MM/yyyy"),
                            Dataenvio = tbTransferenciaArquivos.Dataenvio,
                            Status = tbTransferenciaArquivos.Status
                        };

            return await query.ToListAsync();

            //List<TbTransferenciaArquivos> tbTransferenciaArquivos = await _context.TbTransferenciaArquivos.Where(x => x.Remetente == null).ToListAsync();

            //tbTransferenciaArquivos.All(c =>
            //{
            //    c.nomeEmpresa = c.idEmpresa == null ? "" : _context.CurEmpresas.Where(x => x.IdEmpresa == c.idEmpresa).FirstOrDefault()?.Nome;
            //    c.nomeProduto = c.Produto == null ? "" : _context.TbProdutos.Where(x => x.Produto == c.Produto).FirstOrDefault()?.Nome;
            //    c.nomeUsuario = c.idUsuario == null ? "" : _context.TbUsuarios.Where(x => x.Usuario == c.idUsuario).FirstOrDefault()?.Nome;
            //    return true;
            //});

            //return tbTransferenciaArquivos;
        }

        // GET: api/TbTransferenciaArquivos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbTransferenciaArquivos>> GetTbTransferenciaArquivos(int id)
        {
            var tbTransferenciaArquivos = await _context.TbTransferenciaArquivos.FindAsync(id);

            if (tbTransferenciaArquivos == null)
            {
                return NotFound();
            }

            return tbTransferenciaArquivos;
        }

        // PUT: api/TbTransferenciaArquivos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbTransferenciaArquivos(int id, TbTransferenciaArquivos tbTransferenciaArquivos)
        {
            if (id != tbTransferenciaArquivos.Transferencia)
            {
                return BadRequest();
            }

            _context.Entry(tbTransferenciaArquivos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbTransferenciaArquivosExists(id))
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



        [HttpPost("upload")]
        public string EnviaArquivo([FromForm] IFormFile files)
        {


            if (files.Length > 0)
            {
                try
                {
#pragma warning disable CS0612 // O tipo ou membro é obsoleto
                    if (!Directory.Exists(_environment.WebRootPath + "\\suporte\\"))
#pragma warning restore CS0612 // O tipo ou membro é obsoleto
                    {
#pragma warning disable CS0612 // O tipo ou membro é obsoleto
                        Directory.CreateDirectory(_environment.WebRootPath + "\\suporte\\");
#pragma warning restore CS0612 // O tipo ou membro é obsoleto
                    }

#pragma warning disable CS0612 // O tipo ou membro é obsoleto
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\suporte\\" + files.FileName))
#pragma warning restore CS0612 // O tipo ou membro é obsoleto
                    {
                        files.CopyTo(filestream);
                        filestream.Flush();
                        //@"\uploads\" + noticiaEntity.files.FileName;
                        return "\\suporte\\" + files.FileName;

                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";


        }


        // POST: api/TbTransferenciaArquivos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbTransferenciaArquivos>> PostTbTransferenciaArquivos(TbTransferenciaArquivos tbTransferenciaArquivos)
        {
            try
            {
                //tbTransferenciaArquivos.Para = "gabriel.dassie@hotmail.com";
                //tbTransferenciaArquivos.Remetente = null;
                _context.TbTransferenciaArquivos.Add(tbTransferenciaArquivos);
                await _context.SaveChangesAsync();

                string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
                string to = tbTransferenciaArquivos.Para;   // E-mail do destinatário
                string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
                string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP
                string conteudo = tbTransferenciaArquivos.Comentarios;

                MailMessage message = new MailMessage(from, to, tbTransferenciaArquivos.Assunto, conteudo);
                if (!tbTransferenciaArquivos.Arquivo.Equals(""))
                {

                    message.Attachments.Add(new Attachment(_environment.WebRootPath + "\\suporte\\" + tbTransferenciaArquivos.Arquivo));
                }

                using (SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port))
                {
                    smtp.Credentials = new NetworkCredential(user, pass);
                    smtp.Send(message);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return CreatedAtAction("GetTbTransferenciaArquivos", new
            {
                id = tbTransferenciaArquivos.Transferencia
            }, tbTransferenciaArquivos);
        }

        // DELETE: api/TbTransferenciaArquivos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbTransferenciaArquivos>> DeleteTbTransferenciaArquivos(int id)
        {
            var tbTransferenciaArquivos = await _context.TbTransferenciaArquivos.FindAsync(id);
            if (tbTransferenciaArquivos == null)
            {
                return NotFound();
            }

            _context.TbTransferenciaArquivos.Remove(tbTransferenciaArquivos);
            await _context.SaveChangesAsync();

            return tbTransferenciaArquivos;
        }

        private bool TbTransferenciaArquivosExists(int id)
        {
            return _context.TbTransferenciaArquivos.Any(e => e.Transferencia == id);
        }
    }
}
