using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("CurUsuariosLog")]
    public partial class CurUsuariosLog
    {
        [KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CurUsuariosIdUsuario { get; set; }
        
        [Column("CurUsuario")]
        public CurUsuarios CurUsuarios { get; set; }
        public DateTime DataLog{ get; set; }
        public string Log { get; set; }

    }
}
