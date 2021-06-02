using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class VUsuTurmaTreino
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(127)]
        public string Nome { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public bool DesejaNews { get; set; }
        [Column("idTurma")]
        public int IdTurma { get; set; }
        [Column("idTreinamento")]
        public int IdTreinamento { get; set; }
    }
}
