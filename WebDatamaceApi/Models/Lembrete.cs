using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("lembrete")]
    public partial class Lembrete
    {
        [Key]
        [Column("id_lembrete")]
        public int IdLembrete { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("descricao", TypeName = "text")]
        public string descricao { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime? Data { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("ordem")]
        public int? Ordem { get; set; }


        [NotMapped]
        [Column("DataFormat")]
        public string DataFormat
        {
            get
            {
                if (this.Data != null)
                    return ((DateTime)this.Data).ToString("dd/MM/yyyy");
                else { return "";}

            }
            set { }
        }
    }
}
