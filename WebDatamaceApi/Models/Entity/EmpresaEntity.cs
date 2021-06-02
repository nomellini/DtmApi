using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class EmpresaEntity
    {
        public int Empresa { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Cnpj { get; set; }
        public string Responsavel { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public bool? Status { get; set; }
        public string Cidade { get; set; }
        public bool? Cliente { get; set; }
        public string Uf { get; set; }
        public List<string> EmpresasProdutos { get; set; }
        public bool? Ativado { get; set; }
    }
}
