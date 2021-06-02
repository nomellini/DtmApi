using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_EMPRESASNova")]
    public partial class TbEmpresasnova
    {

        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("EMPRESA")]
        public int Empresa { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Column("CODIGO")]
        [StringLength(7)]
        public string Codigo { get; set; }
        [Column("CNPJ")]
        [StringLength(20)]
        public string Cnpj { get; set; }
        [Column("RESPONSAVEL")]
        [StringLength(150)]
        public string Responsavel { get; set; }
        [Column("EMAIL")]
        [StringLength(250)]
        public string Email { get; set; }
        [Column("DDD")]
        [StringLength(3)]
        public string Ddd { get; set; }
        [Column("FONE")]
        [StringLength(50)]
        public string Fone { get; set; }
        [Column("DATA_CADASTRO", TypeName = "smalldatetime")]
        public DateTime DataCadastro { get; set; }
        [Column("STATUS")]
        public bool Status { get; set; }
        [Column("CIDADE")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
    }
}
