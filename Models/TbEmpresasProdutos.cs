using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_EMPRESAS_PRODUTOS")]
    public partial class TbEmpresasProdutos
    {
        [Column("EMPRESA")]
        public int Empresa { get; set; }

        [Column("PRODUTO")]
        public int Produto { get; set; }

        [ForeignKey(nameof(Empresa))]
        [InverseProperty(nameof(TbEmpresas.TbEmpresasProdutos))]
        public virtual TbEmpresas EmpresaNavigation { get; set; }
        [ForeignKey(nameof(Produto))]
        [InverseProperty(nameof(TbProdutos.TbEmpresasProdutos))]
        public virtual TbProdutos ProdutoNavigation { get; set; }
    }
}
