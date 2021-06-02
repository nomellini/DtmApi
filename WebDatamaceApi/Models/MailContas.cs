using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class MailContas
    {
        [Key]
        [Column("ContaID")]
        public int ContaId { get; set; }
        [StringLength(50)]
        public string Titulo { get; set; }
        [StringLength(50)]
        public string FromName { get; set; }
        [StringLength(50)]
        public string FromMail { get; set; }
        [Column("smtpServer")]
        [StringLength(50)]
        public string SmtpServer { get; set; }
        [Column("smtpLogin")]
        [StringLength(50)]
        public string SmtpLogin { get; set; }
        [Column("smtpPassword")]
        [StringLength(50)]
        public string SmtpPassword { get; set; }
        [Column("portSMTP")]
        public int? PortSmtp { get; set; }
        [Column("sslSMTP")]
        public bool? SslSmtp { get; set; }
        public int? LimiteDiario { get; set; }
        public bool? Ativo { get; set; }
        [StringLength(100)]
        public string Dominios { get; set; }
    }
}
