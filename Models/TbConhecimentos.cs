using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_CONHECIMENTOS")]
    public partial class TbConhecimentos
    {
        [Key]
        [Column("CONHECIMENTO")]
        public int Conhecimento { get; set; }
        [Required]
        [Column("CONTATO")]
        [StringLength(50)]
        public string Contato { get; set; }
        [Required]
        [Column("TEMA")]
        [StringLength(100)]
        public string Tema { get; set; }
        [Column("TELEFONE")]
        [StringLength(50)]
        public string Telefone { get; set; }
        [Column("COMENTARIOS")]
        [StringLength(250)]
        public string Comentarios { get; set; }
        [Required]
        [Column("REMETENTE")]
        [StringLength(100)]
        public string Remetente { get; set; }
        [Required]
        [Column("ARQUIVO")]
        [StringLength(100)]
        public string Arquivo { get; set; }
        [Column("DATAENVIO", TypeName = "smalldatetime")]
        public DateTime Dataenvio { get; set; }
        [Column("STATUS")]
        public byte Status { get; set; }
    }
}
