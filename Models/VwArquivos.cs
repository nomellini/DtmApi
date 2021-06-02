using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class VwArquivos
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
        [Required]
        [StringLength(200)]
        public string Produto { get; set; }
        [Required]
        [StringLength(100)]
        public string Categoria { get; set; }
        [StringLength(1)]
        public string TipoSigla { get; set; }
        [StringLength(50)]
        public string TipoDescricao { get; set; }
        [StringLength(50)]
        public string NomePasta { get; set; }
    }
}
