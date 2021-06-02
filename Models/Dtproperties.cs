using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("dtproperties")]
    public partial class Dtproperties
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("objectid")]
        public int? Objectid { get; set; }
        [Key]
        [Column("property")]
        [StringLength(64)]
        public string Property { get; set; }
        [Column("value")]
        [StringLength(255)]
        public string Value { get; set; }
        [Column("uvalue")]
        [StringLength(255)]
        public string Uvalue { get; set; }
        [Column("lvalue", TypeName = "image")]
        public byte[] Lvalue { get; set; }
        [Column("version")]
        public int Version { get; set; }
    }
}
