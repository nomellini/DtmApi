using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatamaceApi.Models
{
    [Table("TB_USUARIOS")]
    public partial class TbUsuarios
    {
        public TbUsuarios()
        {
            TbTransferenciaArquivosDestinatarioNavigation = new HashSet<TbTransferenciaArquivos>();
            TbTransferenciaArquivosRemetenteNavigation = new HashSet<TbTransferenciaArquivos>();
            TbUsuariosLog = new HashSet<TbUsuariosLog>();
        }

        [Key]
        [Column("USUARIO")]
        public int Usuario { get; set; }
        [Column("EMPRESA")]
        public int Empresa { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(500)]
        public string Email { get; set; }
        [Column("LOGIN")]
        [StringLength(50)]
        public string Login { get; set; }
        [Required]
        [Column("SENHA")]
        [StringLength(50)]
        public string Senha { get; set; }
        [Column("CARGO")]
        [StringLength(50)]
        public string Cargo { get; set; }
        [Column("DDD")]
        [StringLength(5)]
        public string Ddd { get; set; }
        [Column("FONE")]
        [StringLength(50)]
        public string Fone { get; set; }
        [Column("NIVEL")]
        public byte Nivel { get; set; }
        [Column("STATUS")]
        public byte? Status { get; set; }
        [Column("CIDADE")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }

        [ForeignKey(nameof(Empresa))]
        [InverseProperty(nameof(TbEmpresas.TbUsuarios))]
        public virtual TbEmpresas EmpresaNavigation { get; set; }
        [InverseProperty(nameof(TbTransferenciaArquivos.DestinatarioNavigation))]
        public virtual ICollection<TbTransferenciaArquivos> TbTransferenciaArquivosDestinatarioNavigation { get; set; }
        [InverseProperty(nameof(TbTransferenciaArquivos.RemetenteNavigation))]
        public virtual ICollection<TbTransferenciaArquivos> TbTransferenciaArquivosRemetenteNavigation { get; set; }
        [InverseProperty("UsuarioNavigation")]
        public virtual ICollection<TbUsuariosLog> TbUsuariosLog { get; set; }
    }
}
