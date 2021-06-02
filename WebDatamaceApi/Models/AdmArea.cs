using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("admArea")]
    public partial class AdmArea
    {
        [Key]
        [Column("guidArea")]
        public Guid GuidArea { get; set; }
        [Required]
        [StringLength(128)]
        public string Nome { get; set; }
    }
}
