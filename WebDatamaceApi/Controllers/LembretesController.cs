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
    public class LembretesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public LembretesController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Lembretes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lembrete>>> GetLembrete()
        {
            return await _context.Lembrete.OrderBy(d => d.Data).ToListAsync();
        }

        [HttpGet("Ativos")]
        public async Task<ActionResult<IEnumerable<Lembrete>>> GetLembreteAtivos()
        {
            return await _context.Lembrete.Where(x=> x.Status == 1).OrderBy(d=> d.Data).ToListAsync();
        }

        [HttpGet("Inativos")]
        public async Task<ActionResult<IEnumerable<Lembrete>>> GetLembreteInativos()
        {
            return await _context.Lembrete.Where(x => x.Status ==0).OrderBy(d => d.Data).ToListAsync();
        }
        // GET: api/Lembretes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lembrete>> GetLembrete(int id)
        {
            var lembrete = await _context.Lembrete.FindAsync(id);

            if (lembrete == null)
            {
                return NotFound();
            }

            return lembrete;
        }

        // PUT: api/Lembretes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLembrete(int id, Lembrete lembrete)
        {
            if (id != lembrete.IdLembrete)
            {
                return BadRequest();
            }

            _context.Entry(lembrete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LembreteExists(id))
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

        // POST: api/Lembretes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Lembrete>> PostLembrete(Lembrete lembrete)
        {
            _context.Lembrete.Add(lembrete);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLembrete", new { id = lembrete.IdLembrete }, lembrete);
        }

        // DELETE: api/Lembretes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lembrete>> DeleteLembrete(int id)
        {
            var lembrete = await _context.Lembrete.FindAsync(id);
            if (lembrete == null)
            {
                return NotFound();
            }

            _context.Lembrete.Remove(lembrete);
            await _context.SaveChangesAsync();

            return lembrete;
        }


        // DELETE: api/lembretes/5
        [HttpPatch("AtivarLembrete")]
        public async Task<ActionResult<Lembrete>> AtivarLembrete(int id)
        {
            var lembrete = await _context.Lembrete.FindAsync(id);
            if (lembrete == null)
            {
                return NotFound();
            }

            lembrete.Status = 1;

            _context.Entry(lembrete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LembreteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return lembrete;
        }


        // DELETE: api/lembretes/5
        [HttpPatch("InativarLembrete")]
        public async Task<ActionResult<Lembrete>> InativarLembrete(int id)
        {
            var lembrete = await _context.Lembrete.FindAsync(id);
            if (lembrete == null)
            {
                return NotFound();
            }

            lembrete.Status = 0;

            _context.Entry(lembrete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LembreteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return lembrete;
        }

        private bool LembreteExists(int id)
        {
            return _context.Lembrete.Any(e => e.IdLembrete == id);
        }
    }
}
