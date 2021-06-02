using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDatamaceApi.Models;
using WebDatamaceApi.Models.Entity;

namespace WebDatamaceApi.Controllers
{
    [Produces("application/json")]
    [Route("v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CurTurmasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurTurmasController(CoreDbContext context)
        {
            _context = context;
        }


        // GET: api/CurTurmas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetCurTurma(int idTreinamento = 0)
        {
            if (idTreinamento == 0)
            {
                var query = from turma in _context.Set<CurTurma>()
                            join grupo in _context.Set<CurTurmaGrupo>()
                             on turma.IdGrupo equals grupo.IdGrupo
                            join treinamento in _context.Set<CurTreinamento>()
                         on turma.IdTreinamento equals treinamento.IdTreinamento
                            orderby turma.DataInicio descending
                            select new { turma, grupo, treinamento, inscritos = _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count() }
                            ;

                return await query.ToListAsync();
            }
            else
            {
                var query = from turma in _context.Set<CurTurma>()
                            join grupo in _context.Set<CurTurmaGrupo>()
                                on turma.IdGrupo equals grupo.IdGrupo
                            join treinamento in _context.Set<CurTreinamento>()
                      on turma.IdTreinamento equals treinamento.IdTreinamento
                            where turma.IdTreinamento == idTreinamento
                            orderby turma.DataInicio descending
                            select new { turma, grupo, treinamento, inscritos = _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count() };

                return await query.ToListAsync();

                //return await _context.CurTurma.Where(x=> x.IdTreinamento==idTreinamento).ToListAsync();

            }
        }


        // GET: api/CurTurmas
        [HttpGet("GetCurTurmaDisponiveisUsers")]

        public async Task<ActionResult<IEnumerable<dynamic>>> GetCurTurmaDisponiveisUsers(int idUser = 0)
        {
            if (idUser == 0)
            {
                var query = from turma in _context.Set<CurTurma>()
                            join grupo in _context.Set<CurTurmaGrupo>()
                             on turma.IdGrupo equals grupo.IdGrupo
                            join treinamento in _context.Set<CurTreinamento>()
                           on turma.IdTreinamento equals treinamento.IdTreinamento
                            orderby turma.DataInicio descending
                            where turma.Aberta == true
                            select new CurTurmaUsuarioEntity
                            {
                                turma = turma,
                                grupo = grupo,
                                treinamento = treinamento,
                                inscritos =
                            _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                            }
                            ;

                return await query.ToListAsync();
            }
            else
            {
                List<int> curUsuariosTurmas = _context.CurUsuariosTurmas
                    .Where(x => x.IdUsuario == idUser)
                    .Select(r=> r.IdTurma).ToList();


                var query = from turma in _context.Set<CurTurma>()
                            join grupo in _context.Set<CurTurmaGrupo>()
                             on turma.IdGrupo equals grupo.IdGrupo
                            join treinamento in _context.Set<CurTreinamento>()
                            on turma.IdTreinamento equals treinamento.IdTreinamento
                           
                            where turma.Aberta == true && !curUsuariosTurmas.Contains(turma.IdTurma)
                            orderby turma.DataInicio descending
                            select new CurTurmaUsuarioEntity
                            {
                                turma = turma,
                                grupo = grupo,
                                treinamento = treinamento,
                                inscritos =
                            _context.Set<CurUsuariosTurmas>().Where(x => x.IdTurma == turma.IdTurma).Count()
                            };

                return await query.ToListAsync();

                //return await _context.CurTurma.Where(x=> x.IdTreinamento==idTreinamento).ToListAsync();

            }
        }

        //// GET: api/CurTurmas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CurTurma>> GetCurTurma(int id)
        //{
        //    var curTurma = await _context.CurTurma.FindAsync(id);

        //    if (curTurma == null)
        //    {
        //        return NotFound();
        //    }

        //    return curTurma;
        //}

        // PUT: api/CurTurmas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurTurma(int id, CurTurma curTurma)
        {
            if (id != curTurma.IdTurma)
            {
                return BadRequest();
            }



            _context.Entry(curTurma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
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

        // POST: api/CurTurmas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurTurma>> PostCurTurma(CurTurma curTurma)
        {

            try
            {

                CurTurmaGrupo curTurmaGrupo = new CurTurmaGrupo()
                {
                    IdGrupo = 0,
                    NomeGrupo = ((DateTime)curTurma.DataInicio).ToString("MM/yyyy")
                };
                _context.CurTurmaGrupo.Add(curTurmaGrupo);

                await _context.SaveChangesAsync();

                if (curTurmaGrupo.IdGrupo > 0)
                {
                    curTurma.IdGrupo = curTurmaGrupo.IdGrupo;
                    _context.CurTurma.Add(curTurma);
                    await _context.SaveChangesAsync();

                }
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;

            }

            return CreatedAtAction("GetCurTurma", new { id = curTurma.IdTurma }, curTurma);
        }

        // DELETE: api/CurTurmas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurTurma>> DeleteCurTurma(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }

            _context.CurTurma.Remove(curTurma);
            await _context.SaveChangesAsync();

            return curTurma;
        }



        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Duplicar")]
        public async Task<ActionResult<CurTurma>> Duplicar(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }

            curTurma.IdTurma = 0;
            _context.CurTurma.Add(curTurma);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return curTurma;
        }



        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Publicar")]
        public async Task<IActionResult> Publicar(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }


            curTurma.Publicado = true;

            _context.Entry(curTurma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
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



        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Despublicar")]
        public async Task<IActionResult> Despublicar(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }


            curTurma.Publicado = false;

            _context.Entry(curTurma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
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



        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("DespublicarTurma")]
        public async Task<IActionResult> DespublicarTurma(int id)
        {
            var curTurmaOrig = await _context.CurTurma.FindAsync(id);
            if (curTurmaOrig == null)
            {
                return NotFound();
            }


            List<CurTurma> curTurmas = _context.CurTurma.Where(x => x.IdGrupo == curTurmaOrig.IdGrupo).ToList();


            if (curTurmas == null && curTurmas.Count() == 0)
            {
                return NotFound();
            }
            foreach (CurTurma curTurma in curTurmas)
            {
                id = curTurma.IdTurma;
                curTurma.Publicado = false;

                _context.Entry(curTurma).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurTurmaExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

            }



            return NoContent();
        }


        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Encerrar")]
        public async Task<IActionResult> Encerrar(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }

            curTurma.Aberta = false;

            _context.Entry(curTurma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
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


        // PATCH: api/CurTurmas/Duplicar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPatch("Abrir")]
        public async Task<IActionResult> Abrir(int id)
        {
            var curTurma = await _context.CurTurma.FindAsync(id);
            if (curTurma == null)
            {
                return NotFound();
            }

            curTurma.Aberta = true;

            _context.Entry(curTurma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTurmaExists(id))
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

        private bool CurTurmaExists(int id)
        {
            return _context.CurTurma.Any(e => e.IdTurma == id);
        }
    }
}
