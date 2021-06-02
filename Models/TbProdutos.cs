using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_PRODUTOS")]
    public partial class TbProdutos
    {
        public TbProdutos()
        {
            TbArquivos = new HashSet<TbArquivos>();
            TbEmpresasProdutos = new HashSet<TbEmpresasProdutos>();
            TbTransferenciaArquivos = new HashSet<TbTransferenciaArquivos>();
            TbUsuariosProdutos = new HashSet<TbUsuariosProdutos>();
        }

        [Key]
        [Column("PRODUTO")]
        public int Produto { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("STATUS")]
        public bool? Status { get; set; }

        [InverseProperty("ProdutoNavigation")]
        public virtual ICollection<TbArquivos> TbArquivos { get; set; }
        [InverseProperty("ProdutoNavigation")]
        public virtual ICollection<TbEmpresasProdutos> TbEmpresasProdutos { get; set; }
        [InverseProperty("ProdutoNavigation")]
        public virtual ICollection<TbTransferenciaArquivos> TbTransferenciaArquivos { get; set; }
        [InverseProperty("ProdutoNavigation")]
        public virtual ICollection<TbUsuariosProdutos> TbUsuariosProdutos { get; set; }
    }
}
