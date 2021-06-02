using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("tbEnqueteVotado")]
    public partial class TbEnqueteVotado
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
        [Column("id_pesquisa")]
        public int? IdPesquisa { get; set; }
        [Column("votacao")]
        public int? Votacao { get; set; }
    }
}
