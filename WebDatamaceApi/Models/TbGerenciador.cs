using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbGerenciador")]
    public partial class TbGerenciador
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idGerenciador")]
        public int IdGerenciador { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Column("descricao", TypeName = "ntext")]
        public string Descricao { get; set; }
        [Column("idproduto")]
        public int? Idproduto { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
    }
}
