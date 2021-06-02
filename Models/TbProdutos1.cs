using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbProdutos")]
    public partial class TbProdutos1
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdProduto { get; set; }
        [StringLength(200)]
        public string Nome { get; set; }
        [StringLength(200)]
        public string Arquivo { get; set; }
        public bool? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DtUpload { get; set; }
        public int? UserUltimoDown { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DtUltimoDown { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DtInclusao { get; set; }
    }
}
