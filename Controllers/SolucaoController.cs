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
    public class SolucaosController : ControllerBase
    {
        private readonly CoreDbContext _context;
        [Obsolete]
        public static IHostingEnvironment _environment;

        [Obsolete]
        public SolucaosController(CoreDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;

        }

        // GET: api/Solucao
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TbSolucao>>> GetTbSolucao()
        {


            return await _context.TbSolucaos.Select(u => new TbSolucao
            {
                Id = u.Id,
                Slug = u.Slug,
                Conteudo = u.Conteudo,
                ImagePath = u.ImagePath,
                Parent= u.Parent,

                Menu = u.Menu,
                Titulo = u.Titulo
            }).OrderBy(x => x.Id).ToListAsync();
        }


        [HttpGet("GetTbSolucaoParent")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TbSolucao>>> GetTbSolucaoParent()
        {


            return await _context.TbSolucaos.Where(x => x.Parent).Select(u => new TbSolucao
            {
                Id = u.Id,
                Slug = u.Slug,
                Conteudo = u.Conteudo,
                ImagePath = u.ImagePath,
                Parent = u.Parent,

                Menu = u.Menu,
                Titulo = u.Titulo
            }).OrderBy(x => x.Id).ToListAsync();
        }


        [HttpGet("GetImages")]
        [AllowAnonymous]
        public IActionResult GetImages(string name)
        {
            if (string.IsNullOrEmpty(name)) { return NotFound(); }

            if (!Directory.Exists(@"MyStaticFiles/images/solucoes"))
            {
                return NotFound();
            }

            var url = $"MyStaticFiles/images/solucoes/{name}";

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

                    if (!Directory.Exists(@"MyStaticFiles/images/solucoes"))
                    {
                        Directory.CreateDirectory(@"MyStaticFiles/images/solucoes");
                    }

                    using (FileStream filestream = System.IO.File.Create(@"MyStaticFiles/images/solucoes/" + files.FileName))
                    {
                        files.CopyTo(filestream);
                        filestream.Flush();
                        //@"\uploads\" + noticiaEntity.files.FileName;

                    }
                    return @"MyStaticFiles/images/solucoes/" + files.FileName;


                }
                catch (Exception)
                {
                    throw;
                }
            }
            return "";


        }


        // GET: api/Solucao
        [HttpGet("GetTbSolucaoBYSlug")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TbSolucao>>> GetTbSolucaoBYSlug(string Slug)
        {
            if (string.IsNullOrEmpty(Slug))
            {
                return BadRequest();
            }

            return await _context.TbSolucaos.Where(x => x.Slug.Equals(Slug)).Select(u => new TbSolucao
            {
                Id = u.Id,
                Slug = u.Slug,
                Menu = u.Menu,
                Conteudo = u.Conteudo,
                ImagePath = u.ImagePath,
                Parent = u.Parent,

                Titulo = u.Titulo
            }).OrderBy(x => x.Id).ToListAsync();
        }

        // GET: api/Solucao/5
        [HttpGet("{id}")]
        [AllowAnonymous]

        public async Task<ActionResult<TbSolucao>> GetTbSolucao(int id)
        {

            var tbSolucao = await _context.TbSolucaos.FindAsync(id);

            if (tbSolucao == null)
            {
                return NotFound();
            }

            return tbSolucao;
        }

        // PUT: api/Solucao/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbSolucao(int id, SolucaoEntity solucaoEntity)
        {
            if (id != solucaoEntity.Id
                 && string.IsNullOrEmpty(solucaoEntity.Titulo)
                && string.IsNullOrEmpty(solucaoEntity.Slug)
                && string.IsNullOrEmpty(solucaoEntity.Menu)
                && string.IsNullOrEmpty(solucaoEntity.Conteudo)
)
            {
                return BadRequest();
            }

            TbSolucao tbSolucao = _context.TbSolucaos.Where(e => e.Id == solucaoEntity.Id).FirstOrDefault();

            tbSolucao.Slug = solucaoEntity.Slug;
            tbSolucao.Conteudo = solucaoEntity.Conteudo;
            tbSolucao.Menu = solucaoEntity.Menu;
            tbSolucao.Titulo = solucaoEntity.Titulo;
            tbSolucao.ImagePath = solucaoEntity.ImagePath;
            tbSolucao.Parent = solucaoEntity.Parent;

            _context.Entry(tbSolucao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbSolucaoExists(id))
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




        // POST: api/Solucao
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbSolucao>> PostTbSolucao(SolucaoEntity solucaoEntity)
        {
            if (solucaoEntity != null && solucaoEntity.Id == 0
                && !string.IsNullOrEmpty(solucaoEntity.Titulo)
                && !string.IsNullOrEmpty(solucaoEntity.Menu)
                && !string.IsNullOrEmpty(solucaoEntity.Conteudo)
                && !string.IsNullOrEmpty(solucaoEntity.Slug)
                )
            {
                TbSolucao tbSolucao = new TbSolucao()
                {
                    Id = 0,
                    Slug = solucaoEntity.Slug,
                    Conteudo = solucaoEntity.Conteudo,          
                    Menu = solucaoEntity.Menu,
                    ImagePath = solucaoEntity.ImagePath,
                    Titulo = solucaoEntity.Titulo,
                    Parent = solucaoEntity.Parent
                };



                try
                {
                    _context.TbSolucaos.Add(tbSolucao);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetTbSolucao", new { id = tbSolucao.Id }, tbSolucao);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return BadRequest();

        }

        // DELETE: api/Solucao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbSolucao>> DeleteTbSolucao(int id)
        {
            var tbSolucao = await _context.TbSolucaos.FindAsync(id);
            if (tbSolucao == null)
            {
                return NotFound();
            }

            _context.TbSolucaos.Remove(tbSolucao);
            await _context.SaveChangesAsync();

            return tbSolucao;
        }

        private bool TbSolucaoExists(int id)
        {
            return _context.TbSolucaos.Any(e => e.Id == id);
        }
    }
}
