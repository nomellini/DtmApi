using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace WebDatamaceApi.Models
{
    [Table("TB_EMPRESAS")]
    public partial class TbEmpresas
    {
        public TbEmpresas()
        {
            TbEmpresasProdutos = new HashSet<TbEmpresasProdutos>();
            TbUsuarios = new HashSet<TbUsuarios>();
        }

        [Key]
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
        [Required]
        [Column("STATUS")]
        public bool? Status { get; set; }
        [Column("CIDADE")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("ATIVADO")]
        public bool? Ativado { get; set; }

        [Column("Cliente")]
        public bool? Cliente { get; set; }

        [NotMapped]
        [Column("Usuarios")]
        public virtual int Usuarios { get; set; }

        [NotMapped]
        [Column("EmpresasProdutos")]
        public virtual int EmpresasProdutos { get; set; }


        [NotMapped]
        [Column("Empresas")]
        public virtual List<string> Empresas { get; set; }

        [NotMapped]
        [Column("StatusText")]
        public string StatusText { get { return
                    (this.Status != null && (bool)this.Status) ?
                    ((this.Ativado != null && (bool)this.Ativado) ? "Ativo" : "Inativo") : 
                    "Bloqueado"; } set { } }

        [NotMapped]
        [Column("DtCadastroFormat")]
        public string DtCadastroFormat
        {
            get
            {
                return this.DataCadastro.ToString("dd/MM/yyyy");

            }
            set { }
        }

        [NotMapped]
        [Column("FoneFormat")]
        public string FoneFormat
        {
            get
            {
                if (this.Fone.Length >= 8)
                {

                    if (int.TryParse(this.Fone, out int foneInt))
                    {
                        string fone = "(" + this.Ddd + ") " + this.Fone.Substring(0, this.Fone.Length - 4) + "-" + this.Fone.Substring(this.Fone.Length - 4, 4);
                        return fone;
                    }

                }
                return this.Fone;

            }
            set { }
        }

        [JsonIgnore]
        [InverseProperty("EmpresaNavigation")]
        public virtual ICollection<TbEmpresasProdutos> TbEmpresasProdutos { get; set; }
        [JsonIgnore]
        [InverseProperty("EmpresaNavigation")]
        public virtual ICollection<TbUsuarios> TbUsuarios { get; set; }
    }
}
