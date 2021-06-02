using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquisaTipo")]
    public partial class TbPesquisaTipo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idNome")]
        public int IdNome { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFim { get; set; }
        [Column("txtCab", TypeName = "ntext")]
        public string TxtCab { get; set; }
        [Column("txtRod", TypeName = "ntext")]
        public string TxtRod { get; set; }
        [Column("image")]
        [StringLength(255)]
        public string Image { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
    }
}
