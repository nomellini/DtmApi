using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("pesq_satisf_10")]
    public partial class PesqSatisf10
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("id_pesq")]
        public int IdPesq { get; set; }
        [Column("voce_perg1")]
        [StringLength(50)]
        public string VocePerg1 { get; set; }
        [Column("voce_perg2")]
        [StringLength(50)]
        public string VocePerg2 { get; set; }
        [Column("voce_perg3")]
        [StringLength(50)]
        public string VocePerg3 { get; set; }
        [Column("voce_perg4")]
        [StringLength(50)]
        public string VocePerg4 { get; set; }
        [Column("empresa_perg1")]
        [StringLength(50)]
        public string EmpresaPerg1 { get; set; }
        [Column("empresa_perg2")]
        [StringLength(50)]
        public string EmpresaPerg2 { get; set; }
        [Column("produto_perg1")]
        [StringLength(50)]
        public string ProdutoPerg1 { get; set; }
        [Column("produto_perg2")]
        [StringLength(50)]
        public string ProdutoPerg2 { get; set; }
        [Column("produto_perg3")]
        [StringLength(50)]
        public string ProdutoPerg3 { get; set; }
        [Column("produto_perg4")]
        [StringLength(50)]
        public string ProdutoPerg4 { get; set; }
        [Column("produto_perg5")]
        [StringLength(50)]
        public string ProdutoPerg5 { get; set; }
        [Column("produto_perg6")]
        [StringLength(50)]
        public string ProdutoPerg6 { get; set; }
        [Column("produto_coment1")]
        [StringLength(1000)]
        public string ProdutoComent1 { get; set; }
        [Column("produto_coment2")]
        [StringLength(1000)]
        public string ProdutoComent2 { get; set; }
        [Column("produto_coment3")]
        [StringLength(1000)]
        public string ProdutoComent3 { get; set; }
        [Column("produto_coment4")]
        [StringLength(1000)]
        public string ProdutoComent4 { get; set; }
        [Column("produto_coment5")]
        [StringLength(1000)]
        public string ProdutoComent5 { get; set; }
        [Column("produto_coment6")]
        [StringLength(1000)]
        public string ProdutoComent6 { get; set; }
        [Column("data", TypeName = "datetime")]
        public DateTime? Data { get; set; }
        [Column("estado")]
        [StringLength(2)]
        public string Estado { get; set; }
        [Column("id_cliente")]
        [StringLength(50)]
        public string IdCliente { get; set; }
        [Column("empresa_perg3")]
        [StringLength(50)]
        public string EmpresaPerg3 { get; set; }
        [Column("text", TypeName = "text")]
        public string Text { get; set; }
        [Column("produto_perg7")]
        [StringLength(50)]
        public string ProdutoPerg7 { get; set; }
        [Column("produto_perg8")]
        [StringLength(50)]
        public string ProdutoPerg8 { get; set; }
        [Column("produto_coment7")]
        [StringLength(1000)]
        public string ProdutoComent7 { get; set; }
        [Column("produto_coment8")]
        [StringLength(1000)]
        public string ProdutoComent8 { get; set; }
    }
}
