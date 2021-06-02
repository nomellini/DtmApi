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
    public class CurLocalsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurLocalsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/CurLocals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurLocal>>> GetCurLocal()
        {
            return await _context.CurLocal.ToListAsync();
        }

        // GET: api/CurLocals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurLocal>> GetCurLocal(int id)
        {
            var curLocal = await _context.CurLocal.FindAsync(id);

            if (curLocal == null)
            {
                return NotFound();
            }

            return curLocal;
        }

        // PUT: api/CurLocals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurLocal(int id, CurLocal curLocal)
        {
            if (id != curLocal.IdLocal)
            {
                return BadRequest();
            }

            _context.Entry(curLocal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurLocalExists(id))
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

        // POST: api/CurLocals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurLocal>> PostCurLocal(CurLocal curLocal)
        {
            _context.CurLocal.Add(curLocal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurLocal", new { id = curLocal.IdLocal }, curLocal);
        }

        // DELETE: api/CurLocals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurLocal>> DeleteCurLocal(int id)
        {
            var curLocal = await _context.CurLocal.FindAsync(id);
            if (curLocal == null)
            {
                return NotFound();
            }

            _context.CurLocal.Remove(curLocal);
            await _context.SaveChangesAsync();

            return curLocal;
        }

        private bool CurLocalExists(int id)
        {
            return _context.CurLocal.Any(e => e.IdLocal == id);
        }
    }
}
