using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbGerCliSub")]
    public partial class TbGerCliSub
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idSub_pasta")]
        public int IdSubPasta { get; set; }
        [Column("idempresa")]
        public int? Idempresa { get; set; }
        [Column("idusuario")]
        public int? Idusuario { get; set; }
        [Column("idPasta")]
        public int? IdPasta { get; set; }
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Column("descricao", TypeName = "ntext")]
        public string Descricao { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
    }
}
