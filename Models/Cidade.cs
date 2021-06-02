using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("Municipio")]
    public partial class Cidade
    {

        public Cidade()
        {
          
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Codigo")]
        public int Codigo { get; set; }

        [Column("Uf")]
        [StringLength(2)]
        public string Uf { get; set; }

        [Column("Nome")]
        [StringLength(255)]
        public string Nome { get; set; }

    }
}
