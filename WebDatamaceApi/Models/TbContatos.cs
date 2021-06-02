using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbContatos")]
    public partial class TbContatos
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("ctId")]
        public int CtId { get; set; }
        [Column("ctNome")]
        [StringLength(200)]
        public string CtNome { get; set; }
        [Column("ctDDD")]
        [StringLength(3)]
        public string CtDdd { get; set; }
        [Column("ctFone")]
        [StringLength(50)]
        public string CtFone { get; set; }
        [Column("ctEndereco")]
        [StringLength(250)]
        public string CtEndereco { get; set; }
        [Column("ctCidade")]
        [StringLength(50)]
        public string CtCidade { get; set; }
        [Column("ctUF")]
        [StringLength(2)]
        public string CtUf { get; set; }
        [Column("ctBairro")]
        [StringLength(50)]
        public string CtBairro { get; set; }
        [Column("ctCEP")]
        [StringLength(10)]
        public string CtCep { get; set; }
        [Column("ctEmail")]
        [StringLength(150)]
        public string CtEmail { get; set; }
        [Column("ctMsg", TypeName = "ntext")]
        public string CtMsg { get; set; }
        [Column("ctData", TypeName = "smalldatetime")]
        public DateTime? CtData { get; set; }
        [Column("ctStatus")]
        public bool? CtStatus { get; set; }
    }
}
