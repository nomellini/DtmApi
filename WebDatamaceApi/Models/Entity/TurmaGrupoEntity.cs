using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class TurmaGrupoEntity
    {
        public List<TurmaGrupoChildEntity> CurTurmas { get; set; }
        public string CurTurmaGrupo { get; set; }
        public int Periodo{ get; set; }
    }
}
