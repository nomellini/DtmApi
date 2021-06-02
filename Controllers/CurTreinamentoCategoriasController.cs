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
    public class CurTreinamentoCategoriasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurTreinamentoCategoriasController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/CurTreinamentoCategorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurTreinamentoCategoria>>> GetCurTreinamentoCategoria()
        {
            return await _context.CurTreinamentoCategoria.ToListAsync();
        }

        // GET: api/CurTreinamentoCategorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurTreinamentoCategoria>> GetCurTreinamentoCategoria(int id)
        {
            var curTreinamentoCategoria = await _context.CurTreinamentoCategoria.FindAsync(id);

            if (curTreinamentoCategoria == null)
            {
                return NotFound();
            }

            return curTreinamentoCategoria;
        }

        // PUT: api/CurTreinamentoCategorias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurTreinamentoCategoria(int id, CurTreinamentoCategoria curTreinamentoCategoria)
        {
            if (id != curTreinamentoCategoria.IdCategoria)
            {
                return BadRequest();
            }

            _context.Entry(curTreinamentoCategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTreinamentoCategoriaExists(id))
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

        // POST: api/CurTreinamentoCategorias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurTreinamentoCategoria>> PostCurTreinamentoCategoria(CurTreinamentoCategoria curTreinamentoCategoria)
        {
            _context.CurTreinamentoCategoria.Add(curTreinamentoCategoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurTreinamentoCategoria", new { id = curTreinamentoCategoria.IdCategoria }, curTreinamentoCategoria);
        }

        // DELETE: api/CurTreinamentoCategorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurTreinamentoCategoria>> DeleteCurTreinamentoCategoria(int id)
        {
            var curTreinamentoCategoria = await _context.CurTreinamentoCategoria.FindAsync(id);
            if (curTreinamentoCategoria == null)
            {
                return NotFound();
            }

            _context.CurTreinamentoCategoria.Remove(curTreinamentoCategoria);
            await _context.SaveChangesAsync();

            return curTreinamentoCategoria;
        }

        private bool CurTreinamentoCategoriaExists(int id)
        {
            return _context.CurTreinamentoCategoria.Any(e => e.IdCategoria == id);
        }
    }
}
