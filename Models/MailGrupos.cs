using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class MailGrupos
    {
        [Key]
        [Column("GrupoID")]
        public int GrupoId { get; set; }
        [StringLength(50)]
        public string Descricao { get; set; }
        public int? Total { get; set; }
        [StringLength(250)]
        public string Funcao { get; set; }
    }
}
