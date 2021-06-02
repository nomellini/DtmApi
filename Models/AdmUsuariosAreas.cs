using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("admUsuariosAreas")]
    public partial class AdmUsuariosAreas
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        [Column("guidArea")]
        public Guid GuidArea { get; set; }
        [Column("guidAcao")]
        public Guid? GuidAcao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
    }
}
