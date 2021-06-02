using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class CurTreinamentoesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public CurTreinamentoesController(CoreDbContext context)
        {
            _context = context;
        }


        [HttpGet("notAdm")]
        [AllowAnonymous]
        public ActionResult<CurTreinamentonotAdm> GetCurTreinamentonotAdm()
        {

            List<CurTreinamento> curTreinamentos = _context.CurTreinamento.Where(x => x.Publicado).ToListAsync().Result;

            CurTreinamentonotAdm curTreinamentonotAdm = new CurTreinamentonotAdm()
            {
                CurTreinamentos = curTreinamentos.OrderBy(x => x.Nome).ToList(),
                CurTreinamentoCategorias = _context.CurTreinamentoCategoria.OrderBy(x => x.NomeCategoria).ToListAsync().Result,
            };


            return curTreinamentonotAdm;

            //c.InteresseContato =
            //             _context.CurTreinamentoInteresse.Where(x => x.IdTreinamento == c.IdTreinamento && x.Contato).Count();
        }



        [HttpGet("getCalendario")]
        [AllowAnonymous]
        public ActionResult<List<CalendarioTreinamentoEntity>> getCalendario()
        {

            List<CurTreinamento> curTreinamentos = _context.CurTreinamento.Where(x => x.Publicado).ToListAsync().Result;
            List<int> ids = curTreinamentos.Select(x => x.IdTreinamento).ToList();

            DateTime StartDate = DateTime.Now;
            DateTime EndDate = StartDate.AddDays(30);
            int DayInterval = 1;


            List<CurTurma> curTurmas = _context.CurTurma.Where(x =>

                ids.Contains(x.IdTreinamento)
                && x.Publicado
                && (((DateTime)x.DataFinal).Date >= StartDate.Date && ((DateTime)x.DataFinal).Date <= EndDate.Date)

                ).ToListAsync().Result;

            List<CalendarioTreinamentoEntity> dateList = new List<CalendarioTreinamentoEntity>();


            while (StartDate.AddDays(DayInterval) <= EndDate)
            {
                List<CurTurma> curTurmasAux = curTurmas.Where(x =>
                    ((DateTime)x.DataInicio).Date <= StartDate.Date &&
                    ((DateTime)x.DataFinal).Date >= StartDate.Date).ToList();

                if (curTurmasAux.Count() > 0)
                {

                    List<CalendarioTreinamentoEntityChild> calendarioTreinamentoEntityChildren = new List<CalendarioTreinamentoEntityChild>();

                    foreach (var curTurma in curTurmasAux)
                    {
                        CalendarioTreinamentoEntityChild calendarioTreinamentoEntityChild = new CalendarioTreinamentoEntityChild();
                        calendarioTreinamentoEntityChild.curTurma = curTurma;
                        calendarioTreinamentoEntityChild.curTreinamento = curTreinamentos.Where(x => x.IdTreinamento == curTurma.IdTreinamento).FirstOrDefault();
                        calendarioTreinamentoEntityChildren.Add(calendarioTreinamentoEntityChild);

                    }

                    dateList.Add(new CalendarioTreinamentoEntity()
                    {
                        DateFormat = StartDate.Date.ToString("D", CultureInfo.CreateSpecificCulture("pt-BR")),
                        DataCalendario = StartDate,
                        calendarioTreinamentoEntityChildren = calendarioTreinamentoEntityChildren

                    });
                }
                StartDate = StartDate.AddDays(DayInterval);

            }


            return dateList;

        }




        [HttpGet("notAdm/{id}")]
        [AllowAnonymous]
        public ActionResult<CurTreinamentonotAdm> GetCurTreinamentonotAdmById(int id)
        {

            List<CurTreinamento> curTreinamentos = _context.CurTreinamento.Where(x => x.Publicado && x.IdTreinamento == id).ToListAsync().Result;

            CurTreinamentonotAdm curTreinamentonotAdm = new CurTreinamentonotAdm()
            {
                CurTreinamentos = curTreinamentos.OrderBy(x => x.Nome).ToList(),
                CurTreinamentoCategorias = _context.CurTreinamentoCategoria.OrderBy(x => x.NomeCategoria).ToListAsync().Result,
            };


            return curTreinamentonotAdm;

            //c.InteresseContato =
            //             _context.CurTreinamentoInteresse.Where(x => x.IdTreinamento == c.IdTreinamento && x.Contato).Count();
        }


        [HttpPost("formNotificacaoDisp/{id}")]
        [AllowAnonymous]

        public async Task<IActionResult> FormNotificacaoDisp(int id, FormNotificacaoDispEntity formNotificacaoDispEntity)
        {

            var curTreinamento = await _context.CurTreinamento.FindAsync(id);

            if (curTreinamento == null)
            {
                return NotFound();
            }

            CurTreinamentoInteresse curTreinamentoInteresse = new CurTreinamentoInteresse()
            {

                IdTreinamento = id,
                Empresa = formNotificacaoDispEntity.empresa,
                DataCriacao = DateTime.Now,
                Nome = formNotificacaoDispEntity.nome,
                Uf = formNotificacaoDispEntity.estado,
                Email = "email@email.com",
                Contato = false,
                Ddd = "",
                Fone = "",

            };


            try
            {
                _context.CurTreinamentoInteresse.Add(curTreinamentoInteresse);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;

            }
            catch (Exception e)
            {
                throw;
            }

            return NoContent();


        }


        // GET: api/CurTreinamentoes
        [HttpGet]
        public ActionResult<IEnumerable<CurTreinamento>> GetCurTreinamento()
        {

            List<CurTreinamento> curTreinamentos = _context.CurTreinamento.ToListAsync().Result;
            curTreinamentos.All(c =>
            {
                c.InteresseContato =
   _context.CurTreinamentoInteresse.Where(x => x.IdTreinamento == c.IdTreinamento && x.Contato).Count();
                c.InteresseContatoNotSet =
   _context.CurTreinamentoInteresse.Where(x => x.IdTreinamento == c.IdTreinamento && !x.Contato).Count();
                return true;
            });
            return curTreinamentos.OrderBy(x => x.Nome).ToList();

            //c.InteresseContato =
            //             _context.CurTreinamentoInteresse.Where(x => x.IdTreinamento == c.IdTreinamento && x.Contato).Count();
        }

        // GET: api/CurTreinamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurTreinamento>> GetCurTreinamento(int id)
        {
            var curTreinamento = await _context.CurTreinamento.FindAsync(id);

            if (curTreinamento == null)
            {
                return NotFound();
            }

            return curTreinamento;
        }

        // PUT: api/CurTreinamentoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurTreinamento(int id, TreinamentoEntity treinamentoEntity)
        {


            if (id != treinamentoEntity.idTreinamento)
            {
                return BadRequest();
            }

            CurTreinamento curTreinamento = _context.CurTreinamento.Where(x => x.IdTreinamento == treinamentoEntity.idTreinamento).FirstOrDefault();

            if (curTreinamento == null)
            {
                return NotFound();
            }
            curTreinamento.IdCategoria = treinamentoEntity.categoria;
            curTreinamento.Conteudo = treinamentoEntity.conteudo;
            curTreinamento.Descricao = treinamentoEntity.descricao;
            curTreinamento.Modulos = treinamentoEntity.modulos;
            curTreinamento.Nome = treinamentoEntity.nome;
            curTreinamento.Sinopse = treinamentoEntity.sinopse;
            curTreinamento.Preco = treinamentoEntity.preco;
            curTreinamento.CargaHoraria = treinamentoEntity.cargaHoraria;
            curTreinamento.Publicado = treinamentoEntity.status;
            curTreinamento.Tipo = treinamentoEntity.tipo;

            _context.Entry(curTreinamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurTreinamentoExists(id))
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

        // POST: api/CurTreinamentoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurTreinamento>> PostCurTreinamento(TreinamentoEntity treinamentoEntity)
        {
            CurTreinamento curTreinamento = new CurTreinamento()
            {
                IdTreinamento = 0,
                CargaHoraria = treinamentoEntity.cargaHoraria,
                Preco = treinamentoEntity.preco,
                Sinopse = treinamentoEntity.sinopse,
                Conteudo = treinamentoEntity.conteudo,
                DataCriacao = DateTime.Now,
                Descricao = treinamentoEntity.descricao,
                Modulos = treinamentoEntity.modulos,
                Nome = treinamentoEntity.nome,
                Publicado = treinamentoEntity.status,
                IdCategoria = treinamentoEntity.categoria,
                Tipo = treinamentoEntity.tipo,

            };
            try
            {
                _context.CurTreinamento.Add(curTreinamento);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;

            }
            catch (Exception)
            {
                throw;
            }

            return CreatedAtAction("GetCurTreinamento", new { id = curTreinamento.IdTreinamento }, curTreinamento);
        }

        // DELETE: api/CurTreinamentoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurTreinamento>> DeleteCurTreinamento(int id)
        {
            var curTreinamento = await _context.CurTreinamento.FindAsync(id);
            if (curTreinamento == null)
            {
                return NotFound();
            }

            _context.CurTreinamento.Remove(curTreinamento);
            await _context.SaveChangesAsync();

            return curTreinamento;
        }

        private bool CurTreinamentoExists(int id)
        {
            return _context.CurTreinamento.Any(e => e.IdTreinamento == id);
        }
    }
}
