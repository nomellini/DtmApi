using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquisaTitulo")]
    public partial class TbPesquisaTitulo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idPesquisaT")]
        public int IdPesquisaT { get; set; }
        [Column("idPesquisaTipo")]
        public int? IdPesquisaTipo { get; set; }
        [Column(TypeName = "ntext")]
        public string Titulo { get; set; }
        [Column("observacao", TypeName = "ntext")]
        public string Observacao { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
