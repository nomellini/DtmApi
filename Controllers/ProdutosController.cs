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

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class ProdutosController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public ProdutosController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoEntity>>> GetTbProdutos()
        {
            return await _context.TbProdutos.Select(x => new ProdutoEntity
            {
                ContArquivos = _context.TbArquivos.Where(a => a.Produto == x.Produto).Count(),
                Produto = x.Produto,
                Nome = x.Nome,
                Status = x.Status
            }).OrderBy(x => x.Nome).ToListAsync();
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbProdutos>> GetTbProdutos(int id)
        {
            var tbProdutos = await _context.TbProdutos.FindAsync(id);

            if (tbProdutos == null)
            {
                return NotFound();
            }

            return tbProdutos;
        }

        // PUT: api/Produtos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbProdutos(int id, ProdutoEntity produtos)
        {
            if (produtos == null || string.IsNullOrEmpty(produtos.Nome))
            {
                return BadRequest();
            }

            try
            {
                TbProdutos tbProdutos = _context.TbProdutos.Where(x => x.Produto == produtos.Produto).FirstOrDefault();
                if (tbProdutos == null)
                {
                    return NotFound();
                }

                tbProdutos.Nome = produtos.Nome;
                tbProdutos.Status = produtos.Status == null ? false : produtos.Status;

                _context.Entry(tbProdutos).State = EntityState.Modified;


                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbProdutosExists(id))
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

        // POST: api/Produtos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbProdutos>> PostTbProdutos(ProdutoEntity produtos)
        {
            if (produtos == null || string.IsNullOrEmpty(produtos.Nome))
            {
                return BadRequest();
            }

            TbProdutos tbProdutos = new TbProdutos()
            {
                Nome = produtos.Nome,
                Status = produtos.Status == null ? false : produtos.Status,
                Produto = 0
            };
            try
            {
                _context.TbProdutos.Add(tbProdutos);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;

            }

            return CreatedAtAction("GetTbProdutos", new { id = tbProdutos.Produto }, tbProdutos);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbProdutos>> DeleteTbProdutos(int id)
        {

            try
            {
                var tbProdutos = await _context.TbProdutos.FindAsync(id);
                if (tbProdutos == null)
                {
                    return NotFound();
                }


                var lista = _context.TbArquivos.Where(x => x.Produto == id).ToList();
                _context.TbArquivos.RemoveRange(lista);

                await _context.SaveChangesAsync();



                var lista_empresas = _context.TbEmpresasProdutos.Where(x => x.Produto == id).ToList();
                _context.TbEmpresasProdutos.RemoveRange(lista_empresas);

                await _context.SaveChangesAsync();

                var lista_TbTransferenciaArquivos = _context.TbTransferenciaArquivos.Where(x => x.Produto == id).ToList();
                _context.TbTransferenciaArquivos.RemoveRange(lista_TbTransferenciaArquivos);

                await _context.SaveChangesAsync();

                _context.Database.ExecuteSqlRaw($"delete from [dbo].[TB_USUARIOS_PRODUTOS] where produto = {id}");

                //var tbUsuariosProdutos = _context.TbUsuariosProdutos.FromSql Where(x => x.Produto == id).ToList();
                //_context.TbUsuariosProdutos.RemoveRange(tbUsuariosProdutos);

                //_context.SaveChanges();

                _context.TbProdutos.Remove(tbProdutos);
                await _context.SaveChangesAsync();

                return tbProdutos;

            }
            catch (Exception e)
            {
                throw;

            }

        }

        private bool TbProdutosExists(int id)
        {
            return _context.TbProdutos.Any(e => e.Produto == id);
        }
    }
}
