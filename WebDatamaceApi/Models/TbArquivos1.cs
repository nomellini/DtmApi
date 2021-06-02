using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TbArquivos")]
    public partial class TbArquivos1
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdArquivo { get; set; }
        public int IdProduto { get; set; }
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeFisico { get; set; }
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }
        public int? Tamanho { get; set; }
        public int Downloads { get; set; }
        public bool Status { get; set; }
    }
}
