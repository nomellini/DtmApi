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
    public class CurTreinamentoInteressesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurTreinamentoInteressesController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/CurTreinamentoInteresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurTreinamentoInteresse>>> GetCurTreinamentoInteresse()
        {
            return await _context.CurTreinamentoInteresse.ToListAsync();
        }

        // GET: api/CurTreinamentoInteresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CurTreinamentoInteresse>>> GetCurTreinamentoInteresse(int id)
        {
            var curTreinamentoInteresse = await _context.CurTreinamentoInteresse.Where(x=> x.IdTreinamento == id).ToListAsync();

            if (curTreinamentoInteresse == null)
            {
                return NotFound();
            }

            return curTreinamentoInteresse;
        }




        // PUT: api/CurTreinamentoInteresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurTreinamentoInteresse(int id, CurTreinamentoInteresse curTreinamentoInteresse)
        {
            if (id != curTreinamentoInteresse.IdInteresse)
            {
                return BadRequest();
            }

            _context.Entry(curTreinamentoInteresse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTreinamentoInteresseExists(id))
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




        // DELETE: api/lembretes/5
        [HttpPatch("EntrouEmContato")]
        public async Task<ActionResult<CurTreinamentoInteresse>> EntrouEmContato(int id)
        {
            var curTreinamentoInteresse = await _context.CurTreinamentoInteresse.FindAsync(id);
            if (curTreinamentoInteresse == null)
            {
                return NotFound();
            }

            curTreinamentoInteresse.Contato = true;

            _context.Entry(curTreinamentoInteresse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTreinamentoInteresseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return curTreinamentoInteresse;
        }

        // POST: api/CurTreinamentoInteresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurTreinamentoInteresse>> PostCurTreinamentoInteresse(CurTreinamentoInteresse curTreinamentoInteresse)
        {
            _context.CurTreinamentoInteresse.Add(curTreinamentoInteresse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurTreinamentoInteresse", new { id = curTreinamentoInteresse.IdInteresse }, curTreinamentoInteresse);
        }

        // DELETE: api/CurTreinamentoInteresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurTreinamentoInteresse>> DeleteCurTreinamentoInteresse(int id)
        {
            var curTreinamentoInteresse = await _context.CurTreinamentoInteresse.FindAsync(id);
            if (curTreinamentoInteresse == null)
            {
                return NotFound();
            }

            _context.CurTreinamentoInteresse.Remove(curTreinamentoInteresse);
            await _context.SaveChangesAsync();

            return curTreinamentoInteresse;
        }

        private bool CurTreinamentoInteresseExists(int id)
        {
            return _context.CurTreinamentoInteresse.Any(e => e.IdInteresse == id);
        }
    }
}
