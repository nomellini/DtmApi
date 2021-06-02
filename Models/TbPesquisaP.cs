using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquisaP")]
    public partial class TbPesquisaP
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idPesquisaPerg")]
        public int IdPesquisaPerg { get; set; }
        [Column("idPesquisaTipo")]
        public int? IdPesquisaTipo { get; set; }
        [Column("idPesquisaT")]
        public int? IdPesquisaT { get; set; }
        [Column("idtop")]
        public int? Idtop { get; set; }
        [Column("pesquisatexto", TypeName = "ntext")]
        public string Pesquisatexto { get; set; }
        [Column("comente", TypeName = "ntext")]
        public string Comente { get; set; }
        [Column("comenteStatus")]
        public int? ComenteStatus { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
