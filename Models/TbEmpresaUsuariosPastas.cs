using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TbEmpresa_Usuarios_Pastas")]
    public partial class TbEmpresaUsuariosPastas
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdEmpresaUsuarioPasta { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdPasta { get; set; }
    }
}
