using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class TbCategoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(300)]
        public string Descricao { get; set; }
        [StringLength(1)]
        public string TipoSigla { get; set; }
        [StringLength(50)]
        public string TipoDescricao { get; set; }
        [StringLength(50)]
        public string NomePasta { get; set; }
        public bool Ativo { get; set; }
    }
}
