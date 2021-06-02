using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class Usuarios
    {
        [Key]
        [Column("UsuarioID")]
        public int UsuarioId { get; set; }
        [StringLength(50)]
        public string Usuario { get; set; }
        [StringLength(50)]
        public string Senha { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public bool? Administrador { get; set; }
    }
}
