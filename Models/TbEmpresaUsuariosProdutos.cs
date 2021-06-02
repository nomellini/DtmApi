using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresa_Usuarios_Produtos")]
    public partial class TbEmpresaUsuariosProdutos
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdProdutoUsuario { get; set; }
        public int IdUsuario { get; set; }
        public int IdProduto { get; set; }
    }
}
