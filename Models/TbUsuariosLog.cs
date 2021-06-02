using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_USUARIOS_LOG")]
    public partial class TbUsuariosLog
    {
        [Column("USUARIO")]
        public int Usuario { get; set; }
        [Column("ARQUIVO")]
        public int Arquivo { get; set; }
        [Column("LOG", TypeName = "smalldatetime")]
        public DateTime Log { get; set; }
        [Column("IP")]
        [StringLength(15)]
        public string Ip { get; set; }

        [ForeignKey(nameof(Usuario))]
        [InverseProperty(nameof(TbUsuarios.TbUsuariosLog))]
        public virtual TbUsuarios UsuarioNavigation { get; set; }
    }
}
