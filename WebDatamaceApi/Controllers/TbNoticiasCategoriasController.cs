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
    public class TbNoticiasCategoriasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public TbNoticiasCategoriasController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/TbNoticiasCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbNoticiasCategorias>>> GetTbNoticiasCategorias()
        {
            return await _context.TbNoticiasCategorias.ToListAsync();
        }

        // GET: api/TbNoticiasCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbNoticiasCategorias>> GetTbNoticiasCategorias(int id)
        {
            var TbNoticiasCategorias = await _context.TbNoticiasCategorias.FindAsync(id);

            if (TbNoticiasCategorias == null)
            {
                return NotFound();
            }

            return TbNoticiasCategorias;
        }

        // PUT: api/TbNoticiasCategorias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbNoticiasCategorias(int id, TbNoticiasCategorias TbNoticiasCategorias)
        {
            if (id != TbNoticiasCategorias.NotIdCategoria)
            {
                return BadRequest();
            }

            _context.Entry(TbNoticiasCategorias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbNoticiasCategoriasExists(id))
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

        // POST: api/TbNoticiasCategorias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbNoticiasCategorias>> PostTbNoticiasCategorias(TbNoticiasCategorias TbNoticiasCategorias)
        {

            _context.TbNoticiasCategorias.Add(TbNoticiasCategorias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbNoticiasCategorias", new { id = TbNoticiasCategorias.NotIdCategoria }, TbNoticiasCategorias);
        }

        // DELETE: api/TbNoticiasCategorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbNoticiasCategorias>> DeleteTbNoticiasCategorias(int id)
        {
            var TbNoticiasCategorias = await _context.TbNoticiasCategorias.FindAsync(id);
            if (TbNoticiasCategorias == null)
            {
                return NotFound();
            }

            _context.TbNoticiasCategorias.Remove(TbNoticiasCategorias);
            await _context.SaveChangesAsync();

            return TbNoticiasCategorias;
        }

        private bool TbNoticiasCategoriasExists(int id)
        {
            return _context.TbNoticiasCategorias.Any(e => e.NotIdCategoria == id);
        }
    }
}
