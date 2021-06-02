using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class CalendarioTreinamentoEntity
    {

        public string DateFormat { get; set; }
        public DateTime DataCalendario{ get; set; }
        public List<CalendarioTreinamentoEntityChild> calendarioTreinamentoEntityChildren { get; set; }
    }

    public class CalendarioTreinamentoEntityChild
    {
        public CurTreinamento curTreinamento { get; set; }
        public CurTurma curTurma { get; set; }
    }
}
