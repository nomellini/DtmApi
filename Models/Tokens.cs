using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tokens")]
    public partial class Tokens
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Required]
        [Column("token")]
        [StringLength(255)]
        public string Token { get; set; }
        [Required]
        [Column("type")]
        [StringLength(80)]
        public string Type { get; set; }
        [Column("is_revoked")]
        public bool? IsRevoked { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Tokens))]
        public virtual Users User { get; set; }
    }
}
