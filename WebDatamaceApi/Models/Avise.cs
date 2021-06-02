using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("avise")]
    public partial class Avise
    {
        [Key]
        [Column("id_avise")]
        public int IdAvise { get; set; }
        [Column("cpf")]
        [StringLength(50)]
        public string Cpf { get; set; }
        [Column("nome")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("ddd")]
        [StringLength(10)]
        public string Ddd { get; set; }
        [Column("telefone")]
        [StringLength(10)]
        public string Telefone { get; set; }
        [Column("funcao")]
        [StringLength(50)]
        public string Funcao { get; set; }
        [Column("cidade")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Column("uf")]
        [StringLength(10)]
        public string Uf { get; set; }
        [Column("recebe_news")]
        public int? RecebeNews { get; set; }
        [Column("cnpj")]
        [StringLength(50)]
        public string Cnpj { get; set; }
        [Column("razao_social")]
        [StringLength(50)]
        public string RazaoSocial { get; set; }
        [Column("ddd_empresa")]
        [StringLength(10)]
        public string DddEmpresa { get; set; }
        [Column("tel_empresa")]
        [StringLength(10)]
        public string TelEmpresa { get; set; }
        [Column("id_curso")]
        public int? IdCurso { get; set; }
    }
}
