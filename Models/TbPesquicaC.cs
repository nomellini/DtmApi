using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquicaC")]
    public partial class TbPesquicaC
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("idPesquisaP")]
        public int? IdPesquisaP { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataGrava { get; set; }
        [Column("observacao", TypeName = "ntext")]
        public string Observacao { get; set; }
    }
}
