using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("admUsuario")]
    public partial class AdmUsuario
    {
        [Key]
        [Column("idUsuario")]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(127)]
        public string Nome { get; set; }
        [Required]
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(40)]
        public string? Senha { get; set; }
        public bool Bloqueado { get; set; }
        public bool SuperUsers { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
        [Column("customize")]
        [StringLength(50)]
        public string Customize { get; set; }

        [NotMapped]
        [Column("DataCriacaoFormat")]
        public string DataCriacaoFormat
        {
            get
            {
                return this.DataCriacao.ToString("dd/MM/yyyy");

            }
            set { }
        }
    }
}
