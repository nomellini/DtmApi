using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curUsuarios_teste")]
    public partial class CurUsuariosTeste
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        [Column("idEmpresa")]
        public int? IdEmpresa { get; set; }
        [Required]
        [StringLength(127)]
        public string Nome { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(40)]
        public string Senha { get; set; }
        [Column("CPF")]
        [StringLength(20)]
        public string Cpf { get; set; }
        [Column("RG")]
        [StringLength(20)]
        public string Rg { get; set; }
        [Column("DDD")]
        [StringLength(5)]
        public string Ddd { get; set; }
        [StringLength(20)]
        public string Telefone { get; set; }
        [StringLength(40)]
        public string Funcao { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(2)]
        public string Estado { get; set; }
        public bool DesejaNews { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
        [Column("DDD1")]
        [StringLength(5)]
        public string Ddd1 { get; set; }
        [StringLength(20)]
        public string Celular { get; set; }
        [Column("origem")]
        [StringLength(5)]
        public string Origem { get; set; }
    }
}
