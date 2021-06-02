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
    public class MailEmailsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public MailEmailsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/MailEmails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MailEmails>>> GetMailEmails()
        {
            return await _context.MailEmails.ToListAsync();
        }

        // GET: api/MailEmails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MailEmails>> GetMailEmails(string id)
        {
            var mailEmails = await _context.MailEmails.FindAsync(id);

            if (mailEmails == null)
            {
                return NotFound();
            }

            return mailEmails;
        }

        // PUT: api/MailEmails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMailEmails(string id, MailEmails mailEmails)
        {
            if (id != mailEmails.Email)
            {
                return BadRequest();
            }

            _context.Entry(mailEmails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MailEmailsExists(id))
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

        // POST: api/MailEmails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MailEmails>> PostMailEmails(MailEmails mailEmails)
        {
            _context.MailEmails.Add(mailEmails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MailEmailsExists(mailEmails.Email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMailEmails", new { id = mailEmails.Email }, mailEmails);
        }

        // DELETE: api/MailEmails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MailEmails>> DeleteMailEmails(string id)
        {
            var mailEmails = await _context.MailEmails.FindAsync(id);
            if (mailEmails == null)
            {
                return NotFound();
            }

            _context.MailEmails.Remove(mailEmails);
            await _context.SaveChangesAsync();

            return mailEmails;
        }

        private bool MailEmailsExists(string id)
        {
            return _context.MailEmails.Any(e => e.Email == id);
        }
    }
}
