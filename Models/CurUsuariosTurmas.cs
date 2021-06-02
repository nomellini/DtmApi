using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curUsuariosTurmas")]
    public partial class CurUsuariosTurmas
    {
        [Key]
        [Column("idTurma")]
        public int IdTurma { get; set; }
        [Key]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        public bool Aprovado { get; set; }
        public bool Pago { get; set; }
        public bool Presente { get; set; }
        [StringLength(15)]
        public string Resultado { get; set; }
        [StringLength(2048)]
        public string Obs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
    }
}
