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
    public class CidadesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CidadesController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Cidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetCidade()
        {
            return await _context.Cidades.ToListAsync();
        }

        // GET: api/Cidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cidade>> GetCidade(int id)
        {
            var avise = await _context.Cidades.FindAsync(id);

            if (avise == null)
            {
                return NotFound();
            }

            return avise;
        }

        // GET: api/Cidades/5
        [HttpGet("GetByUF")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetByUF(string Uf)
        {
            return await _context.Cidades.Where(x => x.Uf.Equals(Uf.ToUpper())).ToListAsync();

        }

    }
}
