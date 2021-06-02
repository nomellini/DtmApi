using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("SRA010")]
    public partial class Sra010
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int? Matricula { get; set; }
        [Column("RA_NOME")]
        [StringLength(50)]
        public string RaNome { get; set; }
        [Column("RA_ADMISSA", TypeName = "datetime")]
        public DateTime? RaAdmissa { get; set; }
    }
}
