using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class TreinamentoEntity
    {
        public int idTreinamento { get; set; }
        public string cargaHoraria { get; set; }
        public int categoria { get; set; }
        public string conteudo { get; set; }
        public string descricao { get; set; }
        public int modulos { get; set; }
        public string nome { get; set; }
        public string sinopse { get; set; }
        public double preco { get; set; }
        public int tipo { get; set; }
        public bool status { get; set; }
    }
}
