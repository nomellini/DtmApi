using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbFaqInfo")]
    public partial class TbFaqInfo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("fiId")]
        public int FiId { get; set; }
        [Column("fiFTID")]
        public int? FiFtid { get; set; }
        [Column("fiPerg")]
        [StringLength(250)]
        public string FiPerg { get; set; }
        [Column("fiResp", TypeName = "ntext")]
        public string FiResp { get; set; }
        [Column("fiStatus")]
        public byte? FiStatus { get; set; }
    }
}
