using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDatamaceApi.Models.Entity
{
    public class CurTurmaUsuarioEntity
    {

        public CurTurma turma { get; set; }
        public CurTurmaGrupo grupo { get; set; }
        public CurTreinamento treinamento { get; set; }
        public int inscritos { get; set; }

    }
}
