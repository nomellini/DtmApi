using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curTreinamentoInteresse")]
    public partial class CurTreinamentoInteresse
    {
        [Key]
        [Column("idInteresse")]
        public int IdInteresse { get; set; }
        [Column("idTreinamento")]
        public int IdTreinamento { get; set; }
        [Required]
        [StringLength(128)]
        public string Nome { get; set; }
        [Required]
        [StringLength(256)]
        public string Email { get; set; }
        [Column("DDD")]
        [StringLength(5)]
        public string Ddd { get; set; }
        [StringLength(18)]
        public string Fone { get; set; }
        [StringLength(128)]
        public string Empresa { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        public bool Contato { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }


        [NotMapped]
        [Column("FoneFormat")]
        public string FoneFormat
        {
            get
            {
                return this.Ddd + "-" + this.Fone;

            }
            set { }
        }


        [NotMapped]
        [Column("DataCriacaoFormat")]
        public string DataCriacaoFormat
        {
            get
            {
                return this.DataCriacao.ToString("dd/MM/yyyy");

            }
            set { }
        }
    }
}
