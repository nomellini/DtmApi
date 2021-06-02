using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("admAcoes")]
    public partial class AdmAcoes
    {
        [Key]
        [Column("guidAcao")]
        public Guid GuidAcao { get; set; }
        [Column("guidArea")]
        public Guid GuidArea { get; set; }
        [Required]
        [StringLength(128)]
        public string Descricao { get; set; }
    }
}
