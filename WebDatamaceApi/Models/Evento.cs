using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("evento")]
    public partial class Evento
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime? Data { get; set; }
        [Column("nome")]
        [StringLength(50)]
        public string nome { get; set; }


        [Column("descricao")]
        [StringLength(255)]
        public string descricao { get; set; }


        [Column("status")]
        public bool status { get; set; }
    }
}
