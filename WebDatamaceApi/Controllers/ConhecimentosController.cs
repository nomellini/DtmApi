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
    public class ConhecimentosController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public ConhecimentosController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Conhecimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbConhecimentos>>> GetTbConhecimentos()
        {
            return await _context.TbConhecimentos.ToListAsync();
        }

        // GET: api/Conhecimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbConhecimentos>> GetTbConhecimentos(int id)
        {
            var tbConhecimentos = await _context.TbConhecimentos.FindAsync(id);

            if (tbConhecimentos == null)
            {
                return NotFound();
            }

            return tbConhecimentos;
        }

        // PUT: api/Conhecimentos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbConhecimentos(int id, TbConhecimentos tbConhecimentos)
        {
            if (id != tbConhecimentos.Conhecimento)
            {
                return BadRequest();
            }

            _context.Entry(tbConhecimentos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbConhecimentosExists(id))
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

        // POST: api/Conhecimentos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbConhecimentos>> PostTbConhecimentos(TbConhecimentos tbConhecimentos)
        {
            _context.TbConhecimentos.Add(tbConhecimentos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbConhecimentos", new { id = tbConhecimentos.Conhecimento }, tbConhecimentos);
        }

        // DELETE: api/Conhecimentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbConhecimentos>> DeleteTbConhecimentos(int id)
        {
            var tbConhecimentos = await _context.TbConhecimentos.FindAsync(id);
            if (tbConhecimentos == null)
            {
                return NotFound();
            }

            _context.TbConhecimentos.Remove(tbConhecimentos);
            await _context.SaveChangesAsync();

            return tbConhecimentos;
        }

        private bool TbConhecimentosExists(int id)
        {
            return _context.TbConhecimentos.Any(e => e.Conhecimento == id);
        }
    }
}
