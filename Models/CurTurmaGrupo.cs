using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curTurmaGrupo")]
    public partial class CurTurmaGrupo
    {
        [Key]
        [Column("idGrupo")]
        public int IdGrupo { get; set; }
        [Required]
        [StringLength(24)]
        public string NomeGrupo { get; set; }

    }
}
