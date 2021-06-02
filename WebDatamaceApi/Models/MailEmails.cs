using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class MailEmails
    {
        [Key]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Grupo { get; set; }
        public int? LastSend { get; set; }
        public int? TotalSend { get; set; }
        public int? Visitas { get; set; }
        public int? Compras { get; set; }
        public int? Erros { get; set; }
        [StringLength(250)]
        public string Erro { get; set; }
        public bool? Ativo { get; set; }
        [Column("ContaID")]
        public int? ContaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCadastro { get; set; }
    }
}
