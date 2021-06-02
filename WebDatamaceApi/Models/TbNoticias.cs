using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class TbNoticias
    {
        [Key]
        public int NotId { get; set; }
        [StringLength(255)]
        public string NotTitulo { get; set; }
        [StringLength(255)]
        public string NotResenha { get; set; }
        [Column(TypeName = "ntext")]
        public string NotConteudo { get; set; }
        [StringLength(60)]
        public string NotFonte { get; set; }
        [StringLength(50)]
        public string NotImagem { get; set; }
        [StringLength(50)]
        public string NotComentario { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotVigenciaInicio { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotVigenciaFim { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? NotDataCadastro { get; set; }
        public bool? NotStatus { get; set; }
        public int? NotIdCategoria { get; set; }


        [NotMapped]
        public string NomeCategoria { get; set; }

        [NotMapped]
        [Column("NotDataCadastroFormat")]
        public string NotDataCadastroFormat
        {
            get
            {
                return this.NotDataCadastro?.ToString("dd/MM/yyyy");

            }
            set { }
        }
    }
}
