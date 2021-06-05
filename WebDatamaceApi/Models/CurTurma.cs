using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("curTurma")]
    public partial class CurTurma
    {
        [Key]
        [Column("idTurma")]
        public int IdTurma { get; set; }
        [Column("idTreinamento")]
        public int IdTreinamento { get; set; }
        [Column("idGrupo")]


        public int? IdGrupo { get; set; }
        [Column("idLocal")]
        public int? IdLocal { get; set; }
        [Column("idInstrutor")]
        public int? IdInstrutor { get; set; }
        [Column(TypeName = "text")]
        public string Observacao { get; set; }
        public double? Preco { get; set; }
        public int Vagas { get; set; }
        [StringLength(10)]
        public string Periodo { get; set; }
        public int Modulo { get; set; }
        public bool Aberta { get; set; }
        public bool Publicado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFinal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }


        [NotMapped]
        [Column("PrecoFormat")]
        public string PrecoFormat
        {
            get
            {
                if (this.Preco != null)
                {
                    return ((double)this.Preco).ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("pt-br"));
                }
                else {
                    return "R$ 0,00";
                }

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

        [NotMapped]
        [Column("DataFinalFormat")]
        public string DataFinalFormat
        {
            get
            {
                if (this.DataFinal != null)
                    return ((DateTime) this.DataFinal).ToString("dd/MM/yyyy");
                else
                    return "";

            }
            set { }
        }


        [NotMapped]
        [Column("DataInicioFormat")]
        public string DataInicioFormat
        {
            get
            {
                if (this.DataInicio != null)
                    return ((DateTime)this.DataInicio).ToString("dd/MM/yyyy");
                else
                    return "";

            }
            set { }
        }



        [NotMapped]
        [Column("HoraInicioFormat")]
        public string HoraInicioFormat
        {
            get
            {
                if (this.DataInicio != null)
                    return ((DateTime)this.DataInicio).Hour.ToString("D2") + "h"+ ((DateTime)this.DataInicio).Minute.ToString("D2");
                else
                    return "";

            }
            set { }
        }



        [NotMapped]
        [Column("HoraFinalFormat")]
        public string HoraFinalFormat
        {
            get
            {
                if (this.DataInicio != null)
                    return ((DateTime)this.DataFinal).Hour.ToString("D2") + "h" + ((DateTime)this.DataFinal).Minute.ToString("D2");
                else
                    return "";

            }
            set { }
        }




    }
}
