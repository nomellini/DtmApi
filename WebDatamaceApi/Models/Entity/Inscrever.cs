using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class Inscrever
    {

        public string nome { get; set; }
        public string estado{ get; set; }
        public string cidade { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string codigo { get; set; }
        public string cargo { get; set; }
        public bool aceitepagamento{ get; set; }
        public List<int> modulos { get; set; }
    }
}
