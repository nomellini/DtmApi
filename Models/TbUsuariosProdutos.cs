using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_USUARIOS_PRODUTOS")]
    public partial class TbUsuariosProdutos
    {

        [Column("USUARIO")]
        public int Usuario { get; set; }
        [Column("PRODUTO")]
        public int Produto { get; set; }

        [ForeignKey(nameof(Produto))]
        [InverseProperty(nameof(TbProdutos.TbUsuariosProdutos))]
        public virtual TbProdutos ProdutoNavigation { get; set; }

    
    }
}
