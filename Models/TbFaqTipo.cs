using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbFaqTipo")]
    public partial class TbFaqTipo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("ftId")]
        public int FtId { get; set; }
        [Column("ftSite")]
        [StringLength(50)]
        public string FtSite { get; set; }
        [Column("ftNome")]
        [StringLength(200)]
        public string FtNome { get; set; }
        [Column("ftStatus")]
        public byte? FtStatus { get; set; }
    }
}
