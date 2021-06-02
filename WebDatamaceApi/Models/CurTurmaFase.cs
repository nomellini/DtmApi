using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curTurmaFase")]
    public partial class CurTurmaFase
    {
        [Key]
        [Column("idTurma")]
        public int IdTurma { get; set; }
        [Key]
        [Column("idFase")]
        public int IdFase { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Data { get; set; }
    }
}
