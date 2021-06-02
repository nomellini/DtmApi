using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class CurUsuarioEntity
    {
        public int IdUsuario { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdTurma { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Funcao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool DesejaNews { get; set; }
        public bool Status { get; set; }
        public string Celular { get; set; }
        public string Origem { get; set; }

    }
}
