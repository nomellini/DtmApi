using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebDatamaceApi.Models
{
    [Table("curTreinamento")]
    public partial class CurTreinamento
    {
        [Key]
        [Column("idTreinamento")]
        public int IdTreinamento { get; set; }
        [Required]
        [StringLength(127)]
        public string Nome { get; set; }
        [StringLength(2548)]
        public string Sinopse { get; set; }
        [Column(TypeName = "text")]
        public string Descricao { get; set; }
        [Column(TypeName = "text")]
        public string Conteudo { get; set; }
        public double? Preco { get; set; }
        [StringLength(24)]
        public string CargaHoraria { get; set; }
        public int Modulos { get; set; }
        public int Tipo { get; set; }
        public bool Publicado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
        public int? IdCategoria { get; set; }

        [NotMapped]
        [Column("NomeCategoria")]
        public string NomeCategoria { get; set; }

        [NotMapped]
        [Column("InteresseContatoNotSet")]
        public int InteresseContatoNotSet { get; set; }

        [NotMapped]
        [Column("InteresseContato")]
        public int InteresseContato { get; set; }

        [NotMapped]
        [Column("DtCadastroFormat")]
        public string DataCriacaoFormat
        {
            get
            {
                return this.DataCriacao.ToString("dd/MM/yyyy");

            }
            set { }
        }


        [NotMapped]
        [Column("PrecoFormat")]
        public string PrecoFormat
        {
            get
            {
                string specifier;
                CultureInfo culture;
                specifier = "C";
                culture = CultureInfo.CreateSpecificCulture("pt-BR");

                return this.Preco?.ToString(specifier, culture);

            }
            set { }
        }

        [NotMapped]
        [Column("StatusFormat")]
        public string StatusFormat
        {
            get
            {
                return this.Publicado ? "Publicado" : "Não publicado";

            }
            set { }
        }
    }
}
