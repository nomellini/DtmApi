using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("properties")]
    public partial class Properties
    {
        public Properties()
        {
            Images = new HashSet<Images>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        [Column("price", TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Column("latitude", TypeName = "decimal(9, 6)")]
        public decimal Latitude { get; set; }
        [Column("longitude", TypeName = "decimal(9, 6)")]
        public decimal Longitude { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Properties))]
        public virtual Users User { get; set; }
        [InverseProperty("Property")]
        public virtual ICollection<Images> Images { get; set; }
    }
}
