using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class CurTreinamentonotAdm
    {

        public List<CurTreinamento> CurTreinamentos { get; set; }
        public List<CurTreinamentoCategoria> CurTreinamentoCategorias { get; set; }
    }
}
