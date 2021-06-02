using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbGerenciadorUsu")]
    public partial class TbGerenciadorUsu
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idGerenciadorUsu")]
        public int IdGerenciadorUsu { get; set; }
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
