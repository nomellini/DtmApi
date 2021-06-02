using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curInstrutor")]
    public partial class CurInstrutor
    {
        [Key]
        [Column("idInstrutor")]
        public int IdInstrutor { get; set; }
        [Required]
        [StringLength(128)]
        public string Instrutor { get; set; }
        [Column(TypeName = "text")]
        public string Descricao { get; set; }

        [Column("Ativo")]
        public bool Ativo { get; set; }
    }
}
