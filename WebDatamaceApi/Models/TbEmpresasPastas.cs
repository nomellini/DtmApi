using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresasPastas")]
    public partial class TbEmpresasPastas
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdEmpresaPasta { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdPastaPai { get; set; }
        public int? IdUsuario { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(500)]
        public string Descricao { get; set; }
        public bool? Status { get; set; }
    }
}
