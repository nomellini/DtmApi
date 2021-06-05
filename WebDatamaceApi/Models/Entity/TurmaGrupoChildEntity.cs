using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class TurmaGrupoChildEntity
    {
        public CurTurma CurTurma { get; set; }
        public CurTurmaGrupo CurTurmaGrupo { get; set; }
    }
}
