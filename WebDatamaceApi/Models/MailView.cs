using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class MailView
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "datetime")]
        public DateTime? Data { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("CampanhaID")]
        public int? CampanhaId { get; set; }
        [Column("template")]
        [StringLength(50)]
        public string Template { get; set; }
    }
}
