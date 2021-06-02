using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public class TbArquivosController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public static IHostingEnvironment _environment;

        public TbArquivosController(CoreDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;

        }

        // GET: api/TbArquivos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArquivoEntity>>> GetTbArquivos()
        {
            return await _context.TbArquivos.Select(x => new ArquivoEntity
            {
                Arquivo = x.Arquivo,
                descricao = x.Descricao,
                idCategoria = x.Categoria,
                nome = x.Nome,
                Status = x.Status,
                nomeCategoria = _context.TbCategorias.Where(c => c.Categoria == x.Categoria).FirstOrDefault().Nome,
                lastDate = _context.TbUsuariosLog.Where(tb => tb.Arquivo == x.Arquivo).OrderByDescending(x => x.Log).FirstOrDefault().Log.ToString("dd/MM/yyyy hh:mm:ss"),
                lastUsuario = _context.TbUsuarios.Where(us => us.Usuario == (_context.TbUsuariosLog.Where(tb => tb.Arquivo == x.Arquivo).OrderByDescending(x => x.Log).FirstOrDefault().Usuario)).FirstOrDefault().Nome,


            }).ToListAsync();
        }

        // GET: api/TbArquivos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbArquivos>> GetTbArquivos(int id)
        {
            var tbArquivos = await _context.TbArquivos.FindAsync(id);

            if (tbArquivos == null)
            {
                return NotFound();
            }

            return tbArquivos;
        }

        [HttpGet("getbyproduto")]
        public async Task<ActionResult<List<ArquivoEntity>>> GetTbArquivosbyProduto(int idProduto)
        {
            var tbArquivos = await _context.TbArquivos.Where(x => x.Produto == idProduto).Select(x => new ArquivoEntity
            {
                Arquivo = x.Arquivo,
                descricao = x.Descricao,
                idCategoria = x.Categoria,
                nome = x.Nome,
                Status = x.Status,
                nomeCategoria = _context.TbCategorias.Where(c => c.Categoria == x.Categoria).FirstOrDefault().Nome,
                lastDate = _context.TbUsuariosLog.Where(tb => tb.Arquivo == x.Arquivo).OrderByDescending(x => x.Log).FirstOrDefault().Log.ToString("dd/MM/yyyy hh:mm:ss"),
                lastUsuario = _context.TbUsuarios.Where(us => us.Usuario == (_context.TbUsuariosLog.Where(tb => tb.Arquivo == x.Arquivo).OrderByDescending(x => x.Log).FirstOrDefault().Usuario)).FirstOrDefault().Nome,

            }).ToListAsync();

            if (tbArquivos == null)
            {
                return NotFound();
            }

            return tbArquivos;
        }


        [HttpGet("GetArquivos")]
        [AllowAnonymous]
        public IActionResult GetArquivos(string name)
        {
            if (string.IsNullOrEmpty(name)) { return NotFound(); }

            if (!Directory.Exists(@"MyStaticFiles/arquivos"))
            {
                return NotFound();
            }

            var url = $"MyStaticFiles/arquivos/{name}";

            if (!Directory.Exists(url))
            {
                return NotFound();
            }


            return PhysicalFile(url,"application/octet-stream");
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


                    if (!Directory.Exists(@"MyStaticFiles/arquivos"))
                    {
                        Directory.CreateDirectory(@"MyStaticFiles/arquivos");
                    }

                    using (FileStream filestream = System.IO.File.Create(@"MyStaticFiles/arquivos/" + files.FileName))
                    {
                        files.CopyTo(filestream);
                        filestream.Flush();

                    }
                    return @"MyStaticFiles/arquivos/" + files.FileName;


                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";


        }


        // PUT: api/TbArquivos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbArquivos(int id, ArquivoEntity arquivoEntity)
        {
            if (arquivoEntity == null || string.IsNullOrEmpty(arquivoEntity.nome))
            {
                return BadRequest();
            }

            TbArquivos tbArquivos = _context.TbArquivos.Find(arquivoEntity.Arquivo);

            if (tbArquivos == null)
            {
                return NotFound();

            }
            tbArquivos.Nome = arquivoEntity.nome;
            tbArquivos.Descricao = arquivoEntity.descricao;
            tbArquivos.Categoria = arquivoEntity.idCategoria;
            tbArquivos.Produto = arquivoEntity.Produto;
            tbArquivos.Status = arquivoEntity.Status == null ? true : arquivoEntity.Status;


            _context.Entry(tbArquivos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbArquivosExists(id))
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

        // POST: api/TbArquivos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbArquivos>> PostTbArquivos(ArquivoEntity arquivoEntity)
        {
            if (arquivoEntity == null || string.IsNullOrEmpty(arquivoEntity.nome))
            {
                return BadRequest();
            }

            TbArquivos tbArquivos = new TbArquivos
            {
                Nome = arquivoEntity.nome,
                Descricao = arquivoEntity.descricao,
                Categoria = arquivoEntity.idCategoria,
                Produto = arquivoEntity.Produto,
                Status = arquivoEntity.Status == null ? true : arquivoEntity.Status
            };
            try
            {

                _context.TbArquivos.Add(tbArquivos);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return CreatedAtAction("GetTbArquivos", new { id = tbArquivos.Arquivo }, tbArquivos);
        }

        // DELETE: api/TbArquivos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbArquivos>> DeleteTbArquivos(int id)
        {
            var tbArquivos = await _context.TbArquivos.FindAsync(id);
            if (tbArquivos == null)
            {
                return NotFound();
            }

            _context.TbArquivos.Remove(tbArquivos);
            await _context.SaveChangesAsync();

            return tbArquivos;
        }

        private bool TbArquivosExists(int id)
        {
            return _context.TbArquivos.Any(e => e.Arquivo == id);
        }
    }
}
