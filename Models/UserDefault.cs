using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class UserDefault
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("UserID")]
        public int? UserId { get; set; }
        [StringLength(50)]
        public string KeyRef { get; set; }
        [StringLength(50)]
        public string KeyValue { get; set; }
    }
}
