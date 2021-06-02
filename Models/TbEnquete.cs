using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tb_enquete")]
    public partial class TbEnquete
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("idEnquete")]
        public int IdEnquete { get; set; }
        [Column("id_tipo")]
        public int IdTipo { get; set; }
        [Required]
        [StringLength(255)]
        public string Enquete { get; set; }
        [Column("resp1")]
        public int Resp1 { get; set; }
        [Column("resp2")]
        public int Resp2 { get; set; }
        [Column("resp3")]
        public int Resp3 { get; set; }
        [Column("resp4")]
        public int Resp4 { get; set; }
        [Required]
        [Column("comentario")]
        [StringLength(255)]
        public string Comentario { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }
}
