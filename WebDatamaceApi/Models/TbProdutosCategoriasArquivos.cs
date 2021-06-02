using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbProdutosCategoriasArquivos")]
    public partial class TbProdutosCategoriasArquivos
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdProdCatArquivo { get; set; }
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(50)]
        public string Arquivo { get; set; }
        public int Tamanho { get; set; }
        public bool Status { get; set; }
    }
}
