using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_ARQUIVOS")]
    public partial class TbArquivos
    {
        [Key]
        [Column("ARQUIVO")]
        public int Arquivo { get; set; }
        [Column("PRODUTO")]
        public int Produto { get; set; }
        [Column("CATEGORIA")]
        public int Categoria { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Column("DESCRICAO")]
        [StringLength(250)]
        public string Descricao { get; set; }
        [Required]
        [Column("STATUS")]
        public bool? Status { get; set; }

        [ForeignKey(nameof(Categoria))]
        [InverseProperty(nameof(TbCategorias.TbArquivos))]
        public virtual TbCategorias CategoriaNavigation { get; set; }
        [ForeignKey(nameof(Produto))]
        [InverseProperty(nameof(TbProdutos.TbArquivos))]
        public virtual TbProdutos ProdutoNavigation { get; set; }
    }
}
