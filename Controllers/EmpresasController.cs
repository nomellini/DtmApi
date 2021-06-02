using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
    public class EmpresasController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public EmpresasController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Empresas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbEmpresas>>> GetTbEmpresas()
        {
            return await _context.TbEmpresas.Select(x => new TbEmpresas
            {
                Ativado = x.Ativado,
                Cnpj = x.Cnpj,
                DataCadastro = x.DataCadastro,
                Cidade = x.Cidade,
                Ddd = x.Ddd,
                Codigo = x.Codigo,
                Email = x.Email,
                Fone = x.Fone,
                Nome = x.Nome,
                Responsavel = x.Responsavel,
                Empresa = x.Empresa,
                Status = x.Status,
                FoneFormat = x.FoneFormat,
                Cliente = x.Cliente,
                Uf = x.Uf,
                Usuarios = _context.CurUsuarios.Where(u => u.IdEmpresa == x.Empresa).Count(),
                EmpresasProdutos = _context.TbEmpresasProdutos.Where(e => e.Empresa == x.Empresa).Count(),
                Empresas = _context.TbProdutos.Where(pi => _context
                            .TbEmpresasProdutos.
                            Where(e => e.Empresa == x.Empresa).Select(p => p.Produto).Contains(pi.Produto)).Select(t => t.Nome).ToList()
            }
            ).OrderBy(asq=> asq.Nome)
                .ToListAsync();
        }

        // GET: api/Empresas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbEmpresas>> GetTbEmpresas(int id)
        {
            var tbEmpresas = await _context.TbEmpresas.FindAsync(id);

            if (tbEmpresas == null)
            {
                return NotFound();
            }

            return tbEmpresas;
        }

        // PUT: api/Empresas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbEmpresas(int id, EmpresaEntity empresas)
        {
            if (empresas == null && id != empresas.Empresa
                && String.IsNullOrEmpty(empresas.Cnpj)
                && String.IsNullOrEmpty(empresas.Codigo)
                && String.IsNullOrEmpty(empresas.Nome)
                && String.IsNullOrEmpty(empresas.Responsavel)
                && String.IsNullOrEmpty(empresas.Email))
            {
                return BadRequest();
            }
            TbEmpresas tbEmpresas = _context.TbEmpresas.Where(e => e.Empresa == empresas.Empresa).FirstOrDefault();
            if (tbEmpresas == null)
            {
                return NotFound();
            }

            string numero = "";
            string ddd = "";
            if (Regex.Match(empresas.Fone, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
            {
                // Remove qualquer caracter que não seja numérico
                numero = CleanPhone(empresas.Fone);
                // Pega os 2 primeiros caracteres
                ddd = numero.Substring(0, 2);
                numero = numero.Substring(2, numero.Length - 2);
            }

            tbEmpresas.Email = empresas.Email;
            tbEmpresas.Cnpj = empresas.Cnpj;
            tbEmpresas.Codigo = empresas.Codigo;
            tbEmpresas.Responsavel = empresas.Responsavel;
            tbEmpresas.Nome = empresas.Nome;
            tbEmpresas.Ativado = empresas.Ativado;
            tbEmpresas.Cidade = empresas.Cidade;
            tbEmpresas.Status = empresas.Status;
            tbEmpresas.Uf = empresas.Uf;
            tbEmpresas.Fone = numero;
            tbEmpresas.Ddd = ddd;
            tbEmpresas.Cliente = empresas.Cliente;

            _context.Entry(tbEmpresas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                if (tbEmpresas.Empresa > 0)
                {
                    List<TbEmpresasProdutos> tbEmpresasProdutosRemover = _context.TbEmpresasProdutos.Where(x => x.Empresa == tbEmpresas.Empresa).ToList();
                    if(tbEmpresasProdutosRemover != null && tbEmpresasProdutosRemover.Count() > 0)
                    {
                        _context.TbEmpresasProdutos.RemoveRange(tbEmpresasProdutosRemover);
                        await _context.SaveChangesAsync();
                    }

                    if (empresas.EmpresasProdutos != null && empresas.EmpresasProdutos.Count > 0)
                    {
                        foreach (var produto in empresas.EmpresasProdutos)
                        {
                            var produtoEntity = _context.TbProdutos.Where(x => x.Nome.Equals(produto)).FirstOrDefault();
                            if (produtoEntity != null)
                            {
                                TbEmpresasProdutos tbEmpresasProdutos = new TbEmpresasProdutos()
                                {
                                    Empresa = tbEmpresas.Empresa,
                                    Produto = produtoEntity.Produto
                                };
                                _context.TbEmpresasProdutos.Add(tbEmpresasProdutos);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbEmpresasExists(id))
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


        private static Regex digitsOnly = new Regex(@"[^\d]");

        public static string CleanPhone(string phone)
        {
            return digitsOnly.Replace(phone, "");
        }

        // POST: api/Empresas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult> PostTbEmpresas(EmpresaEntity empresas)
        {
            if (empresas != null && empresas.Empresa == 0
                && !String.IsNullOrEmpty(empresas.Cnpj)
                && !String.IsNullOrEmpty(empresas.Codigo)
                && !String.IsNullOrEmpty(empresas.Nome)
                && !String.IsNullOrEmpty(empresas.Responsavel)
                && !String.IsNullOrEmpty(empresas.Email)
                )
            {
                string numero = "";
                string ddd = "";
                if (Regex.Match(empresas.Fone, @"\((\d{2})\)\s?(\d{4,5}\-?\d{4})").Success)
                {
                    // Remove qualquer caracter que não seja numérico
                    numero = CleanPhone(empresas.Fone);
                    // Pega os 2 primeiros caracteres
                    ddd = numero.Substring(0, 2);
                    numero = numero.Substring(2, numero.Length - 2);

                }

                TbEmpresas tbEmpresas = new TbEmpresas()
                {
                    DataCadastro = DateTime.Now,
                    Email = empresas.Email,
                    Cnpj = empresas.Cnpj,
                    Codigo = empresas.Codigo,
                    Responsavel = empresas.Responsavel,
                    Nome = empresas.Nome,
                    Ativado = empresas.Ativado,
                    Cidade = empresas.Cidade,
                    Empresa = 0,
                    Status = empresas.Status,
                    Cliente = empresas.Cliente,
                    Uf = empresas.Uf.ToUpper(),
                    Fone = numero,
                    Ddd = ddd,
                };
                _context.TbEmpresas.Add(tbEmpresas);
                try
                {
                    await _context.SaveChangesAsync();
                    if (tbEmpresas.Empresa > 0)
                    {
                        if (empresas.EmpresasProdutos != null && empresas.EmpresasProdutos.Count > 0)
                        {
                            foreach (var produto in empresas.EmpresasProdutos)
                            {
                                var produtoEntity = _context.TbProdutos.Where(x => x.Nome.Equals(produto)).FirstOrDefault();
                                if (produtoEntity != null)
                                {
                                    TbEmpresasProdutos tbEmpresasProdutos = new TbEmpresasProdutos()
                                    {
                                        Empresa = tbEmpresas.Empresa,
                                        Produto = produtoEntity.Produto
                                    };
                                    _context.TbEmpresasProdutos.Add(tbEmpresasProdutos);
                                    await _context.SaveChangesAsync();
                                }
                            }
                        }

                        return CreatedAtAction("GetTbEmpresas", new { id = tbEmpresas.Empresa }, tbEmpresas);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return BadRequest();
        }

        // DELETE: api/Empresas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbEmpresas>> DeleteTbEmpresas(int id)
        {

            try
            {
                var tbEmpresas = await _context.TbEmpresas.FindAsync(id);
                if (tbEmpresas == null)
                {
                    return NotFound();
                }

                _context.TbEmpresasProdutos.RemoveRange(_context.TbEmpresasProdutos.Where(x=> x.Empresa==id));
                await _context.SaveChangesAsync();

                List<TbUsuarios> tbUsuarios = _context.TbUsuarios.Where(x => x.Empresa == id).ToList();
                _context.TbUsuariosLog.RemoveRange(_context.TbUsuariosLog.Where(x => tbUsuarios.Select(p=> p.Usuario).Contains(x.Usuario)));
                await _context.SaveChangesAsync();


                //_context.TbUsuariosProdutos.RemoveRange(_context.TbUsuariosProdutos.Where(x => tbUsuarios.Select(p => p.Usuario).Contains(x.Usuario)));
                //await _context.SaveChangesAsync();


                foreach (var item in tbUsuarios)
                {
                    _context.Database.ExecuteSqlRaw($"delete from [dbo].[TB_USUARIOS_PRODUTOS] where usuario = {item.Usuario}");
                }


                _context.TbUsuarios.RemoveRange(_context.TbUsuarios.Where(x => x.Empresa == id));
                await _context.SaveChangesAsync();

              

                _context.TbEmpresas.Remove(tbEmpresas);
                await _context.SaveChangesAsync();
                return tbEmpresas;

            }
            catch (Exception e) {
                throw;

            }
        }

        private bool TbEmpresasExists(int id)
        {
            return _context.TbEmpresas.Any(e => e.Empresa == id);
        }
    }
}
