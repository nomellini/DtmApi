using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresa_Usuarios")]
    public partial class TbEmpresaUsuarios
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("euId")]
        public int EuId { get; set; }
        [Column("euEpId")]
        public int? EuEpId { get; set; }
        [Column("euNome")]
        [StringLength(100)]
        public string EuNome { get; set; }
        [Column("euEmail")]
        [StringLength(100)]
        public string EuEmail { get; set; }
        [Column("euSenha")]
        [StringLength(100)]
        public string EuSenha { get; set; }
        [Column("euNivel")]
        public int? EuNivel { get; set; }
        [Column("euStatus")]
        public bool? EuStatus { get; set; }
        [Column("euCargo")]
        [StringLength(50)]
        public string EuCargo { get; set; }
        [Column("euFone")]
        [StringLength(50)]
        public string EuFone { get; set; }
    }
}
