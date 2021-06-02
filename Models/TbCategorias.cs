using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_CATEGORIAS")]
    public partial class TbCategorias
    {
        public TbCategorias()
        {
            TbArquivos = new HashSet<TbArquivos>();
        }

        [Key]
        [Column("CATEGORIA")]
        public int Categoria { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        public string Nome { get; set; }

        [InverseProperty("CategoriaNavigation")]
        public virtual ICollection<TbArquivos> TbArquivos { get; set; }
    }
}
