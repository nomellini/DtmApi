using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curEmpresas")]
    public partial class CurEmpresas
    {
        [Key]
        [Column("idEmpresa")]
        public int IdEmpresa { get; set; }
        [Required]
        [StringLength(256)]
        public string Nome { get; set; }
        [StringLength(256)]
        public string RazaoSocial { get; set; }
        [Column("DDD")]
        [StringLength(5)]
        public string Ddd { get; set; }
        [StringLength(15)]
        public string Telefone { get; set; }
        [Column("CNPJ")]
        [StringLength(20)]
        public string Cnpj { get; set; }
        public bool Cliente { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }

        [NotMapped]
        [Column("Usuarios")]
        public virtual int Usuarios { get; set; }

        [NotMapped]
        [Column("DataCriacaoFormat")]
        public string DtCadastroFormat
        {
            get
            {
                return this.DataCriacao.ToString("dd/MM/yyyy");

            }
            set { }
        }

        [NotMapped]
        [Column("FoneFormat")]
        public string FoneFormat
        {
            get
            {
                if (this.Telefone.Length >= 10)
                {

                    if (int.TryParse(this.Telefone, out int foneInt))
                    {
                        string fone = "(" + this.Ddd + ") " + this.Telefone.Substring(0, this.Telefone.Length - 4) + "-" + this.Telefone.Substring(this.Telefone.Length - 4, 4);
                        return fone;
                    }

                }
                return this.Telefone;

            }
            set { }
        }
    }
}
