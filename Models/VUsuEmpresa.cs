using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class VUsuEmpresa
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("USUARIO")]
        public int Usuario { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(500)]
        public string Email { get; set; }
        [Column("CARGO")]
        [StringLength(50)]
        public string Cargo { get; set; }
        [Column("CIDADE")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("EMPRESA")]
        public int Empresa { get; set; }
        [Required]
        [Column("NOME_EMP")]
        [StringLength(100)]
        public string NomeEmp { get; set; }
    }
}
