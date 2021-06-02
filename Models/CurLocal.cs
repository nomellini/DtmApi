using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curLocal")]
    public partial class CurLocal
    {
        [Key]
        [Column("idLocal")]
        public int IdLocal { get; set; }
        [Required]
        [StringLength(128)]
        public string Local { get; set; }
        [Column(TypeName = "text")]
        public string Descricao { get; set; }
        [Column("emailRecebe")]
        [StringLength(120)]
        public string EmailRecebe { get; set; }
    }
}
