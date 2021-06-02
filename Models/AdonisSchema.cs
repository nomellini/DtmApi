using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("adonis_schema")]
    public partial class AdonisSchema
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("batch")]
        public int? Batch { get; set; }
        [Column("migration_time", TypeName = "datetime")]
        public DateTime? MigrationTime { get; set; }
    }
}
