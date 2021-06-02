using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class MailCampanhas
    {
        [Key]
        [Column("CampanhaID")]
        public int CampanhaId { get; set; }
        [StringLength(50)]
        public string Titulo { get; set; }
        [Column(TypeName = "text")]
        public string Conteudo { get; set; }
        [StringLength(100)]
        public string Grupo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataProgramada { get; set; }
        public bool? Ativo { get; set; }
        public int? TotalEnviado { get; set; }
        public int? TotalErro { get; set; }
        public int? TotalRetornado { get; set; }
        public int? TotalLido { get; set; }
        public int? TotalVisitas { get; set; }
        public int? TotalCompras { get; set; }
    }
}
