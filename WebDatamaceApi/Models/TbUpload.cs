using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbUpload")]
    public partial class TbUpload
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idupload")]
        public int Idupload { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Column("descricao", TypeName = "ntext")]
        public string Descricao { get; set; }
        [Column("idempresa")]
        public int? Idempresa { get; set; }
        [Column("idUsuario")]
        public int? IdUsuario { get; set; }
        [Column("idPasta")]
        public int? IdPasta { get; set; }
        [Column("idSubPasta")]
        public int? IdSubPasta { get; set; }
        [Column("contador")]
        public int? Contador { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime? Data { get; set; }
        public bool? Status { get; set; }
    }
}
