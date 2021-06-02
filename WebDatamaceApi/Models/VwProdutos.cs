using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class VwProdutos
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int IdProduto { get; set; }
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        public bool Status { get; set; }
        public int? QtdeArquivos { get; set; }
    }
}
