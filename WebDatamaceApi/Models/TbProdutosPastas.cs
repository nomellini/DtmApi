using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class TbProdutosPastas
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdProdutoPasta { get; set; }
        public int? IdProduto { get; set; }
        public int? IdPastaPai { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(500)]
        public string Descricao { get; set; }
        public bool? Status { get; set; }
    }
}
