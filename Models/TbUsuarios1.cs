using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbUsuarios")]
    public partial class TbUsuarios1
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("usId")]
        public int UsId { get; set; }
        [Column("usLogin")]
        [StringLength(50)]
        public string UsLogin { get; set; }
        [Column("usSenha")]
        [StringLength(50)]
        public string UsSenha { get; set; }
        [Column("usTipo")]
        public int? UsTipo { get; set; }
        [Column("usAreas")]
        [StringLength(50)]
        public string UsAreas { get; set; }
        [Column("usStatus")]
        public bool? UsStatus { get; set; }
    }
}
