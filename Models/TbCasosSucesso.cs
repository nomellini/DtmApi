using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbCasosSucesso")]
    public partial class TbCasosSucesso
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("casId")]
        public int CasId { get; set; }
        [Column("castitulo")]
        [StringLength(150)]
        public string Castitulo { get; set; }
        [Column("casResumo")]
        [StringLength(150)]
        public string CasResumo { get; set; }
        [Column("casTexto", TypeName = "ntext")]
        public string CasTexto { get; set; }
        [Column("casData")]
        [StringLength(50)]
        public string CasData { get; set; }
        [Column("casFonte")]
        [StringLength(100)]
        public string CasFonte { get; set; }
        [Column("casStatus")]
        public bool? CasStatus { get; set; }
    }
}
