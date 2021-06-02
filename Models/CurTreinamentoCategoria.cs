using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curTreinamentoCategoria")]
    public partial class CurTreinamentoCategoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Column("nomeCategoria")]
        [StringLength(100)]
        public string NomeCategoria { get; set; }
    }
}
