using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEmpresasPastasArquivos")]
    public partial class TbEmpresasPastasArquivos
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int IdClientePastaArquivo { get; set; }
        public int? IdPasta { get; set; }
        [Required]
        [StringLength(250)]
        public string NomeArquivo { get; set; }
        public int Tamanho { get; set; }
        public int? Downloads { get; set; }
        public bool? Status { get; set; }
    }
}
