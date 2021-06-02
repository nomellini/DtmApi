using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class VUsuarioProduto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("USUARIO")]
        public int Usuario { get; set; }
        [Column("PRODUTO")]
        public int Produto { get; set; }
        [Column("EMPRESA")]
        public int Empresa { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(500)]
        public string Email { get; set; }
        [Column("STATUS")]
        public byte? Status { get; set; }
    }
}
