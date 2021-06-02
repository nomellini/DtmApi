using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDatamaceApi.Models;

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class TbCategoriasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public TbCategoriasController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/TbCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbCategorias>>> GetTbCategorias()
        {
            return await _context.TbCategorias.ToListAsync();
        }

        // GET: api/TbCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbCategorias>> GetTbCategorias(int id)
        {
            var tbCategorias = await _context.TbCategorias.FindAsync(id);

            if (tbCategorias == null)
            {
                return NotFound();
            }

            return tbCategorias;
        }

        // PUT: api/TbCategorias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbCategorias(int id, TbCategorias tbCategorias)
        {
            if (id != tbCategorias.Categoria)
            {
                return BadRequest();
            }

            _context.Entry(tbCategorias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbCategoriasExists(id))
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

        // POST: api/TbCategorias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbCategorias>> PostTbCategorias(TbCategorias tbCategorias)
        {
            _context.TbCategorias.Add(tbCategorias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbCategorias", new { id = tbCategorias.Categoria }, tbCategorias);
        }

        // DELETE: api/TbCategorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbCategorias>> DeleteTbCategorias(int id)
        {
            var tbCategorias = await _context.TbCategorias.FindAsync(id);
            if (tbCategorias == null)
            {
                return NotFound();
            }

            _context.TbCategorias.Remove(tbCategorias);
            await _context.SaveChangesAsync();

            return tbCategorias;
        }

        private bool TbCategoriasExists(int id)
        {
            return _context.TbCategorias.Any(e => e.Categoria == id);
        }
    }
}
