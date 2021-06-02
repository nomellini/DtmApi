using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("images")]
    public partial class Images
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("property_id")]
        public int? PropertyId { get; set; }
        [Required]
        [Column("path")]
        [StringLength(255)]
        public string Path { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(PropertyId))]
        [InverseProperty(nameof(Properties.Images))]
        public virtual Properties Property { get; set; }
    }
}
