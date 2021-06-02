using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbPesquisaComent")]
    public partial class TbPesquisaComent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("id_Coment")]
        public int IdComent { get; set; }
        [Column("idUsuario")]
        public int? IdUsuario { get; set; }
        [Column("idPesquisaTipo")]
        public int? IdPesquisaTipo { get; set; }
        [Column("idPesquisaTitulo")]
        public int? IdPesquisaTitulo { get; set; }
        [Column("idPesquisaEnquete")]
        public int? IdPesquisaEnquete { get; set; }
        [Column(TypeName = "ntext")]
        public string Comente { get; set; }
    }
}
