using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("users")]
    public partial class Users
    {
        public Users()
        {
            Properties = new HashSet<Properties>();
            Tokens = new HashSet<Tokens>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("username")]
        [StringLength(80)]
        public string Username { get; set; }
        [Required]
        [Column("email")]
        [StringLength(254)]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        [StringLength(60)]
        public string Password { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Properties> Properties { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Tokens> Tokens { get; set; }
    }
}
