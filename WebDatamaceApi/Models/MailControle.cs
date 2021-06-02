using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("mail_controle")]
    public partial class MailControle
    {
        [Key]
        [Column("id_controle")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdControle { get; set; }
        [Column("conteudo", TypeName = "text")]
        public string Conteudo { get; set; }
        [Column("usuario_remetente")]
        [StringLength(2000)]
        public string UsuarioRemetente { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime? Data { get; set; }
        [Column("email_destinatario", TypeName = "text")]
        public string EmailDestinatario { get; set; }
        [Column("enviado")]
        [StringLength(2000)]
        public string Enviado { get; set; }
        [Column("template")]
        [StringLength(2000)]
        public string Template { get; set; }
        [Column("tema")]
        [StringLength(2000)]
        public string Tema { get; set; }
        [Column("remetente")]
        [StringLength(2000)]
        public string Remetente { get; set; }
        [Column("produto")]
        [StringLength(2000)]
        public string Produto { get; set; }
        [Column("curso")]
        [StringLength(2000)]
        public string Curso { get; set; }
    }
}
