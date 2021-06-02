using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresa_Produtos")]
    public partial class TbEmpresaProdutos
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("epProId")]
        public int EpProId { get; set; }
        [Column("epId")]
        public int? EpId { get; set; }
        [Column("proId")]
        public int? ProId { get; set; }
    }
}
