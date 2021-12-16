using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class FaleConoscoEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Telefone { get; set; }
        public string Info { get; set; }
        public string EstadoSelected { get; set; }
        public string Cidadeselected { get; set; }
        public string Assunto { get; set; }
    }
}
