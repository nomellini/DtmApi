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
    public class CurInstrutorsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurInstrutorsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/CurInstrutors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurInstrutor>>> GetCurInstrutor()
        {
            return await _context.CurInstrutor.ToListAsync();
        }

        // GET: api/CurInstrutors
        [HttpGet("Ativos")]
        public async Task<ActionResult<IEnumerable<CurInstrutor>>> GetCurInstrutorAtivos()
        {
            return await _context.CurInstrutor.Where(x => x.Ativo).ToListAsync();
        }

        // GET: api/CurInstrutors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurInstrutor>> GetCurInstrutor(int id)
        {
            var curInstrutor = await _context.CurInstrutor.FindAsync(id);

            if (curInstrutor == null)
            {
                return NotFound();
            }

            return curInstrutor;
        }

        // PUT: api/CurInstrutors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurInstrutor(int id, CurInstrutor curInstrutor)
        {
            if (id != curInstrutor.IdInstrutor)
            {
                return BadRequest();
            }

            _context.Entry(curInstrutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurInstrutorExists(id))
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

        // POST: api/CurInstrutors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurInstrutor>> PostCurInstrutor(CurInstrutor curInstrutor)
        {
            _context.CurInstrutor.Add(curInstrutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurInstrutor", new { id = curInstrutor.IdInstrutor }, curInstrutor);
        }

        // DELETE: api/CurInstrutors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurInstrutor>> DeleteCurInstrutor(int id)
        {
            var curInstrutor = await _context.CurInstrutor.FindAsync(id);
            if (curInstrutor == null)
            {
                return NotFound();
            }

            _context.CurInstrutor.Remove(curInstrutor);
            await _context.SaveChangesAsync();

            return curInstrutor;
        }

        private bool CurInstrutorExists(int id)
        {
            return _context.CurInstrutor.Any(e => e.IdInstrutor == id);
        }
    }
}
