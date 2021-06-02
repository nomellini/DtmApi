using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbGerenciadorCli")]
    public partial class TbGerenciadorCli
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idGerenciadorCli")]
        public int IdGerenciadorCli { get; set; }
        [Column("idempresa")]
        public int? Idempresa { get; set; }
        [Column("idusuario")]
        public int? Idusuario { get; set; }
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Column("descricao", TypeName = "ntext")]
        public string Descricao { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
    }
}
