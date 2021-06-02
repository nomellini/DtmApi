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
    public class UsuariosController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public UsuariosController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbUsuarios>>> GetTbUsuarios()
        {
            return await _context.TbUsuarios.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbUsuarios>> GetTbUsuarios(int id)
        {
            var tbUsuarios = await _context.TbUsuarios.FindAsync(id);

            if (tbUsuarios == null)
            {
                return NotFound();
            }

            return tbUsuarios;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbUsuarios(int id, TbUsuarios tbUsuarios)
        {
            if (id != tbUsuarios.Usuario)
            {
                return BadRequest();
            }

            _context.Entry(tbUsuarios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbUsuariosExists(id))
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

        // POST: api/Usuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TbUsuarios>> PostTbUsuarios(TbUsuarios tbUsuarios)
        {
            _context.TbUsuarios.Add(tbUsuarios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbUsuarios", new { id = tbUsuarios.Usuario }, tbUsuarios);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbUsuarios>> DeleteTbUsuarios(int id)
        {
            var tbUsuarios = await _context.TbUsuarios.FindAsync(id);
            if (tbUsuarios == null)
            {
                return NotFound();
            }

            _context.TbUsuarios.Remove(tbUsuarios);
            await _context.SaveChangesAsync();

            return tbUsuarios;
        }

        private bool TbUsuariosExists(int id)
        {
            return _context.TbUsuarios.Any(e => e.Usuario == id);
        }
    }
}
