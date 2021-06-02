using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbProdutosCategorias")]
    public partial class TbProdutosCategorias
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdProdCategoria { get; set; }
        public int IdProduto { get; set; }
        [StringLength(50)]
        public string Categoria { get; set; }
        public bool Status { get; set; }
    }
}
