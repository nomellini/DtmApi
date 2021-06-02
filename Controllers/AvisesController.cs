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
    public class AvisesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public AvisesController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Avises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avise>>> GetAvise()
        {
            return await _context.Avise.ToListAsync();
        }

        // GET: api/Avises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Avise>> GetAvise(int id)
        {
            var avise = await _context.Avise.FindAsync(id);

            if (avise == null)
            {
                return NotFound();
            }

            return avise;
        }

        // PUT: api/Avises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvise(int id, Avise avise)
        {
            if (id != avise.IdAvise)
            {
                return BadRequest();
            }

            _context.Entry(avise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AviseExists(id))
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

        // POST: api/Avises
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Avise>> PostAvise(Avise avise)
        {
            _context.Avise.Add(avise);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AviseExists(avise.IdAvise))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAvise", new { id = avise.IdAvise }, avise);
        }

        // DELETE: api/Avises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Avise>> DeleteAvise(int id)
        {
            var avise = await _context.Avise.FindAsync(id);
            if (avise == null)
            {
                return NotFound();
            }

            _context.Avise.Remove(avise);
            await _context.SaveChangesAsync();

            return avise;
        }

        private bool AviseExists(int id)
        {
            return _context.Avise.Any(e => e.IdAvise == id);
        }
    }
}
