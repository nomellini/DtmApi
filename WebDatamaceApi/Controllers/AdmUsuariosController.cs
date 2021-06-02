using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
    public class AdmUsuariosController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public AdmUsuariosController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/AdmUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdmUsuario>>> GetAdmUsuario()
        {
            return await _context.AdmUsuario.ToListAsync();
        }

        // GET: api/AdmUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdmUsuario>> GetAdmUsuario(int id)
        {
            var admUsuario = await _context.AdmUsuario.FindAsync(id);

            if (admUsuario == null)
            {
                return NotFound();
            }

            return admUsuario;
        }


        private static string CreateMD5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // PUT: api/AdmUsuarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmUsuario(int id, AdmUsuario admUsuario)
        {
            if (id != admUsuario.IdUsuario)
            {
                return BadRequest();
            }
            try
            {


                if (!admUsuario.Senha.Equals(""))
            {

                admUsuario.Senha = CreateMD5(admUsuario.Senha);
                _context.Entry(admUsuario).State = EntityState.Modified;

            }
            else {
                AdmUsuario admUsuario1 = _context.AdmUsuario.Find(admUsuario.IdUsuario);
                admUsuario1.SuperUsers = admUsuario.SuperUsers;
                admUsuario1.Nome = admUsuario.Nome;
                _context.Entry(admUsuario1).State = EntityState.Modified;

            }

           

           
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdmUsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception e) {
                throw;

            }

            return NoContent();
        }

        // POST: api/AdmUsuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AdmUsuario>> PostAdmUsuario(AdmUsuario admUsuario)
        {
            admUsuario.DataCriacao = DateTime.Now;
            admUsuario.Senha = CreateMD5(admUsuario.Senha);

            _context.AdmUsuario.Add(admUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmUsuario", new { id = admUsuario.IdUsuario }, admUsuario);
        }

        // DELETE: api/AdmUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdmUsuario>> DeleteAdmUsuario(int id)
        {
            var admUsuario = await _context.AdmUsuario.FindAsync(id);
            if (admUsuario == null)
            {
                return NotFound();
            }


            _context.AdmUsuario.Remove(admUsuario);
            await _context.SaveChangesAsync();

            return admUsuario;
        }



        // DELETE: api/AdmUsuarios/5
        [HttpPatch("BloquearAdmUsuario")]
        public async Task<ActionResult<AdmUsuario>> BloquearAdmUsuario(int id)
        {
            var admUsuario = await _context.AdmUsuario.FindAsync(id);
            if (admUsuario == null)
            {
                return NotFound();
            }

            admUsuario.Bloqueado = true;

            _context.Entry(admUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdmUsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return admUsuario;
        }


        // DELETE: api/AdmUsuarios/5
        [HttpPatch("DesbloquearAdmUsuario")]
        public async Task<ActionResult<AdmUsuario>> DesbloquearAdmUsuario(int id)
        {
            var admUsuario = await _context.AdmUsuario.FindAsync(id);
            if (admUsuario == null)
            {
                return NotFound();
            }

            admUsuario.Bloqueado = false;

            _context.Entry(admUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdmUsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return admUsuario;
        }

        private bool AdmUsuarioExists(int id)
        {
            return _context.AdmUsuario.Any(e => e.IdUsuario == id);
        }
    }
}
