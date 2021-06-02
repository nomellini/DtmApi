using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresas")]
    public partial class TbEmpresas1
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("epId")]
        public int EpId { get; set; }
        [Column("epRazao")]
        [StringLength(255)]
        public string EpRazao { get; set; }
        [Column("epStatus")]
        public bool? EpStatus { get; set; }
    }
}
