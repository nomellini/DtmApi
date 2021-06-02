using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_TRANSFERENCIA_ARQUIVOS")]
    public partial class TbTransferenciaArquivos
    {
        [Key]
        [Column("TRANSFERENCIA")]
        public int Transferencia { get; set; }
        [Column("REMETENTE")]
        public int? Remetente { get; set; }
        [Column("DESTINATARIO")]
        public int? Destinatario { get; set; }

        [Column("PARA")]
        [StringLength(100)]
        public string Para { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Column("ASSUNTO")]
        [StringLength(100)]
        public string Assunto { get; set; }
        [Column("COMENTARIOS")]
        [StringLength(250)]
        public string Comentarios { get; set; }
        [Required]
        [Column("ARQUIVO")]
        [StringLength(50)]
        public string Arquivo { get; set; }
        [Column("PRODUTO")]
        public int? Produto { get; set; }

        [Column("idEmpresa")]
        public int? idEmpresa { get; set; }

        [Column("idUsuario")]
        public int? idUsuario { get; set; }


        [NotMapped]
        [Column("nomeEmpresa")]
        public string nomeEmpresa { get; set; }


        [NotMapped]
        [Column("nomeProduto")]
        public string nomeProduto { get; set; }



        [NotMapped]
        [Column("nomeUsuario")]
        public string nomeUsuario { get; set; }


        [NotMapped]
        [Column("DataEnvioFormat")]
        public string DataEnvioFormat
        {
            get
            {
                return this.Dataenvio.ToString("dd/MM/yyyy");

            }
            set { }
        }

        [Column("DATAENVIO", TypeName = "smalldatetime")]
        public DateTime Dataenvio { get; set; }
        [Column("STATUS")]
        public byte Status { get; set; }

        [JsonIgnore]

        [ForeignKey(nameof(Destinatario))]
        [InverseProperty(nameof(TbUsuarios.TbTransferenciaArquivosDestinatarioNavigation))]
        public virtual TbUsuarios DestinatarioNavigation { get; set; }
        [JsonIgnore]

        [ForeignKey(nameof(Produto))]
        [InverseProperty(nameof(TbProdutos.TbTransferenciaArquivos))]
        public virtual TbProdutos ProdutoNavigation { get; set; }
        [JsonIgnore]

        [ForeignKey(nameof(Remetente))]
        [InverseProperty(nameof(TbUsuarios.TbTransferenciaArquivosRemetenteNavigation))]
        public virtual TbUsuarios RemetenteNavigation { get; set; }
    }
}
