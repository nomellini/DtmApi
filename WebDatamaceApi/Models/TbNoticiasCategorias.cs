using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    public partial class TbNoticiasCategorias
    {
        [Key]
        public int? NotIdCategoria { get; set; }
        [StringLength(255)]
        public string NomeCategoria { get; set; }
    }
}
