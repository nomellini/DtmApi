using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("Estado")]
    public partial class Estado
    {

        public Estado() { }

        
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("CodigoUf")]
        public int CodigoUf { get; set; }
        [Column("Regiao")]
        public int Regiao { get; set; }

        [Column("Uf")]
        [StringLength(2)]
        public string Uf { get; set; }

        [Column("Nome")]

        [StringLength(50)]
        public string Nome { get; set; }

    }
}
