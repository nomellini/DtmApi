using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("Ordersteste")]
    public partial class Ordersteste1
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
    }
}
