using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
    public class NoticiasController : ControllerBase
    {
        private readonly CoreDbContext _context;
        [Obsolete]
        public static IHostingEnvironment _environment;

        [Obsolete]
        public NoticiasController(CoreDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;

        }

        // GET: api/Noticias
        [HttpGet]
        [AllowAnonymous]

        public async Task<ActionResult<IEnumerable<TbNoticias>>> GetTbNoticias()
        {


            return await _context.TbNoticias.Select(u => new TbNoticias
            {
                NotId = u.NotId,
                NotIdCategoria = u.NotIdCategoria,
                NotConteudo = u.NotConteudo,
                NotDataCadastro = u.NotDataCadastro,
                NotFonte = u.NotFonte,
                NotResenha = u.NotResenha,
                NotImagem = u.NotImagem,
                NotVigenciaFim = u.NotVigenciaFim,
                NotTitulo = u.NotTitulo,
                NotStatus = u.NotStatus,
                NotVigenciaInicio = u.NotVigenciaInicio,
                NotComentario = u.NotComentario,
                NomeCategoria = _context.TbNoticiasCategorias.Where(x => x.NotIdCategoria == u.NotIdCategoria).FirstOrDefault().NomeCategoria
            }).OrderByDescending(x => x.NotDataCadastro).ToListAsync();
        }

        // GET: api/Noticias/5
        [HttpGet("{id}")]
        [AllowAnonymous]

        public async Task<ActionResult<TbNoticias>> GetTbNoticias(int id)
        {

            var tbNoticias = await _context.TbNoticias.FindAsync(id);

            if (tbNoticias == null)
            {
                return NotFound();
            }

            return tbNoticias;
        }

        // PUT: api/Noticias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbNoticias(int id, NoticiaEntity noticiaEntity)
        {
            if (id != noticiaEntity.NotId
                 && !string.IsNullOrEmpty(noticiaEntity.NotTitulo)
                && !string.IsNullOrEmpty(noticiaEntity.NotResenha)
                && noticiaEntity.NotIdCategoria != 0
                && !string.IsNullOrEmpty(noticiaEntity.NotConteudo)
                && noticiaEntity.NotVigenciaFim != null
                && noticiaEntity.NotVigenciaInicio != null)
            {
                return BadRequest();
            }

            TbNoticias tbNoticias = _context.TbNoticias.Where(e => e.NotId == noticiaEntity.NotId).FirstOrDefault();

            tbNoticias.NotComentario = noticiaEntity.NotComentario;
            tbNoticias.NotVigenciaInicio = noticiaEntity.NotVigenciaInicio;
            tbNoticias.NotVigenciaFim = noticiaEntity.NotVigenciaFim;
            tbNoticias.NotConteudo = noticiaEntity.NotConteudo;
            tbNoticias.NotIdCategoria = noticiaEntity.NotIdCategoria;
            tbNoticias.NotResenha = noticiaEntity.NotResenha;
            tbNoticias.NotFonte = noticiaEntity.NotFonte;
            tbNoticias.NotImagem = noticiaEntity.NotImagem;
            tbNoticias.NotStatus = noticiaEntity.NotStatus;
            tbNoticias.NotTitulo = noticiaEntity.NotTitulo;

            _context.Entry(tbNoticias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbNoticiasExists(id))
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


        [HttpGet("GetImages")]
        [AllowAnonymous]
        public IActionResult GetImages(string name)
        {
            if (string.IsNullOrEmpty(name)) { return NotFound(); }

            if (!Directory.Exists(@"MyStaticFiles/images/noticias"))
            {
                return NotFound();
            }

            var url = $"MyStaticFiles/images/noticias/{name}";

            if (!System.IO.File.Exists(url))
            {
                return NotFound();
            }

            return PhysicalFile(url, "image/png");
              
        }

        [HttpPost("upload")]
        public string EnviaArquivo([FromForm] IFormFile files)
        {

            if (files.Length > 0)
            {
                try
                {

                    if (!Directory.Exists(@"MyStaticFiles"))
                    {
                        Directory.CreateDirectory(@"MyStaticFiles");
                    }

                    if (!Directory.Exists(@"MyStaticFiles/images"))
                    {
                        Directory.CreateDirectory(@"MyStaticFiles/images");
                    }

                    if (!Directory.Exists(@"MyStaticFiles/images/noticias"))
                    {
                        Directory.CreateDirectory(@"MyStaticFiles/images/noticias");
                    }

                    using (FileStream filestream = System.IO.File.Create(@"MyStaticFiles/images/noticias/" + files.FileName))
                    {
                        files.CopyTo(filestream);
                        filestream.Flush();
                        //@"\uploads\" + noticiaEntity.files.FileName;

                    }
                    return @"MyStaticFiles/images/noticias/" + files.FileName;


                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";


        }


        // POST: api/Noticias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbNoticias>> PostTbNoticias(NoticiaEntity noticiaEntity)
        {
            if (noticiaEntity != null && noticiaEntity.NotId == 0
                && !string.IsNullOrEmpty(noticiaEntity.NotTitulo)
                && !string.IsNullOrEmpty(noticiaEntity.NotResenha)
                && noticiaEntity.NotIdCategoria != 0
                && !string.IsNullOrEmpty(noticiaEntity.NotConteudo)
                && noticiaEntity.NotVigenciaFim != null
                && noticiaEntity.NotVigenciaInicio != null
                )
            {
                TbNoticias tbNoticias = new TbNoticias()
                {
                    NotId = 0,
                    NotComentario = noticiaEntity.NotComentario,
                    NotVigenciaInicio = noticiaEntity.NotVigenciaInicio,
                    NotVigenciaFim = noticiaEntity.NotVigenciaFim,
                    NotConteudo = noticiaEntity.NotConteudo,
                    NotIdCategoria = noticiaEntity.NotIdCategoria,
                    NotResenha = noticiaEntity.NotResenha,
                    NotDataCadastro = DateTime.Now,
                    NotFonte = noticiaEntity.NotFonte,
                    NotImagem = noticiaEntity.NotImagem,
                    NotStatus = noticiaEntity.NotStatus,
                    NotTitulo = noticiaEntity.NotTitulo


                };



                try
                {
                    _context.TbNoticias.Add(tbNoticias);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetTbNoticias", new { id = tbNoticias.NotId }, tbNoticias);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return BadRequest();

        }

        // DELETE: api/Noticias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbNoticias>> DeleteTbNoticias(int id)
        {
            var tbNoticias = await _context.TbNoticias.FindAsync(id);
            if (tbNoticias == null)
            {
                return NotFound();
            }

            _context.TbNoticias.Remove(tbNoticias);
            await _context.SaveChangesAsync();

            return tbNoticias;
        }

        private bool TbNoticiasExists(int id)
        {
            return _context.TbNoticias.Any(e => e.NotId == id);
        }
    }
}
