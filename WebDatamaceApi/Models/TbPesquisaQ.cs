using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquisaQ")]
    public partial class TbPesquisaQ
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idquestao")]
        public int Idquestao { get; set; }
        [Column("idPesquisaTipo")]
        public int? IdPesquisaTipo { get; set; }
        [Column("idPesquisaT")]
        public int? IdPesquisaT { get; set; }
        [Column("idPesquisaP")]
        public int? IdPesquisaP { get; set; }
        [Column("questao")]
        [StringLength(250)]
        public string Questao { get; set; }
        [Column("resultado", TypeName = "decimal(18, 0)")]
        public decimal? Resultado { get; set; }
    }
}
