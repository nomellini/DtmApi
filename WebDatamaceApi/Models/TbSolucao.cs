using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbsolucao")]
    public partial class TbSolucao
    {
        public TbSolucao()
        {
         
        }

        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("slug")]
        [StringLength(250)]
        public string Slug { get; set; }

        [Required]
        [Column("menu")]
        [StringLength(250)]
        public string Menu { get; set; }

        [Required]
        [Column("titulo")]
        [StringLength(250)]
        public string Titulo { get; set; }

        [Column("imagePath")]
        [StringLength(250)]
        public string ImagePath { get; set; }


        [Column("parent")]
        public bool Parent { get; set; }


        [Required]
        //[Column("conteudo")]
        [Column("conteudo",TypeName = "ntext")]

        public string Conteudo { get; set; }

    }
}
