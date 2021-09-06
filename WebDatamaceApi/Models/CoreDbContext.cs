using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebDatamaceApi.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AdmAcoes> AdmAcoes { get; set; }
        public virtual DbSet<AdmArea> AdmArea { get; set; }
        public virtual DbSet<AdmUsuario> AdmUsuario { get; set; }
        public virtual DbSet<AdmUsuariosAreas> AdmUsuariosAreas { get; set; }
        public virtual DbSet<AdonisSchema> AdonisSchema { get; set; }
        public virtual DbSet<Avise> Avise { get; set; }
        public virtual DbSet<CurEmpresas> CurEmpresas { get; set; }
        public virtual DbSet<CurInstrutor> CurInstrutor { get; set; }
        public virtual DbSet<CurLocal> CurLocal { get; set; }
        public virtual DbSet<CurTreinamento> CurTreinamento { get; set; }
        public virtual DbSet<CurTreinamentoCategoria> CurTreinamentoCategoria { get; set; }
        public virtual DbSet<CurTreinamentoInteresse> CurTreinamentoInteresse { get; set; }
        public virtual DbSet<CurTurma> CurTurma { get; set; }
        public virtual DbSet<CurTurmaFase> CurTurmaFase { get; set; }
        public virtual DbSet<CurTurmaGrupo> CurTurmaGrupo { get; set; }
        public virtual DbSet<CurUsuarios> CurUsuarios { get; set; }
        public virtual DbSet<CurUsuariosLog> CurUsuariosLog { get; set; }
        public virtual DbSet<CurUsuariosTeste> CurUsuariosTeste { get; set; }
        public virtual DbSet<CurUsuariosTurmas> CurUsuariosTurmas { get; set; }
        public virtual DbSet<Dtproperties> Dtproperties { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Lembrete> Lembrete { get; set; }
        public virtual DbSet<MailCampanhas> MailCampanhas { get; set; }
        public virtual DbSet<MailContas> MailContas { get; set; }
        public virtual DbSet<MailControle> MailControle { get; set; }
        public virtual DbSet<MailEmails> MailEmails { get; set; }
        public virtual DbSet<MailGrupos> MailGrupos { get; set; }
        public virtual DbSet<MailHistory> MailHistory { get; set; }
        public virtual DbSet<MailView> MailView { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersTeste> OrdersTeste { get; set; }
        public virtual DbSet<Ordersteste1> Ordersteste1 { get; set; }
        public virtual DbSet<PesqSatif8> PesqSatif8 { get; set; }
        public virtual DbSet<PesqSatisf> PesqSatisf { get; set; }
        public virtual DbSet<PesqSatisf10> PesqSatisf10 { get; set; }
        public virtual DbSet<PesqSatisf11> PesqSatisf11 { get; set; }
        public virtual DbSet<PesqSatisf12> PesqSatisf12 { get; set; }
        public virtual DbSet<PesqSatisf13> PesqSatisf13 { get; set; }
        public virtual DbSet<PesqSatisf14> PesqSatisf14 { get; set; }
        public virtual DbSet<PesqSatisf2> PesqSatisf2 { get; set; }
        public virtual DbSet<PesqSatisf3> PesqSatisf3 { get; set; }
        public virtual DbSet<PesqSatisf4> PesqSatisf4 { get; set; }
        public virtual DbSet<PesqSatisf5> PesqSatisf5 { get; set; }
        public virtual DbSet<PesqSatisf6> PesqSatisf6 { get; set; }
        public virtual DbSet<PesqSatisf7> PesqSatisf7 { get; set; }
        public virtual DbSet<PesqSatisf8> PesqSatisf8 { get; set; }
        public virtual DbSet<PesqSatisf9> PesqSatisf9 { get; set; }
        public virtual DbSet<PesqSatisfExtra> PesqSatisfExtra { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<Sra010> Sra010 { get; set; }
        public virtual DbSet<TbArquivos> TbArquivos { get; set; }
        public virtual DbSet<TbArquivos1> TbArquivos1 { get; set; }
        public virtual DbSet<TbCasosSucesso> TbCasosSucesso { get; set; }
        public virtual DbSet<TbCategoria> TbCategoria { get; set; }
        public virtual DbSet<TbCategorias> TbCategorias { get; set; }
        public virtual DbSet<TbConhecimentos> TbConhecimentos { get; set; }
        public virtual DbSet<TbContatos> TbContatos { get; set; }
        public virtual DbSet<TbEmpresaProdutos> TbEmpresaProdutos { get; set; }
        public virtual DbSet<TbEmpresaUsuarios> TbEmpresaUsuarios { get; set; }
        public virtual DbSet<TbEmpresaUsuariosPastas> TbEmpresaUsuariosPastas { get; set; }
        public virtual DbSet<TbEmpresaUsuariosProdutos> TbEmpresaUsuariosProdutos { get; set; }
        public virtual DbSet<TbEmpresas> TbEmpresas { get; set; }
        public virtual DbSet<TbEmpresas1> TbEmpresas1 { get; set; }
        public virtual DbSet<TbEmpresasPastas> TbEmpresasPastas { get; set; }
        public virtual DbSet<TbEmpresasPastasArquivos> TbEmpresasPastasArquivos { get; set; }
        public virtual DbSet<TbEmpresasProdutos> TbEmpresasProdutos { get; set; }
        public virtual DbSet<TbEmpresasnova> TbEmpresasnova { get; set; }
        public virtual DbSet<TbEnquete> TbEnquete { get; set; }
        public virtual DbSet<TbEnqueteVotado> TbEnqueteVotado { get; set; }
        public virtual DbSet<TbFaqInfo> TbFaqInfo { get; set; }
        public virtual DbSet<TbFaqTipo> TbFaqTipo { get; set; }
        public virtual DbSet<TbGerCliSub> TbGerCliSub { get; set; }
        public virtual DbSet<TbGerenciador> TbGerenciador { get; set; }
        public virtual DbSet<TbGerenciadorCli> TbGerenciadorCli { get; set; }
        public virtual DbSet<TbGerenciadorUsu> TbGerenciadorUsu { get; set; }
        public virtual DbSet<TbNoticias> TbNoticias { get; set; }
        public virtual DbSet<TbNoticiasCategorias> TbNoticiasCategorias { get; set; }
        public virtual DbSet<TbPesquicaC> TbPesquicaC { get; set; }
        public virtual DbSet<TbPesquisaComent> TbPesquisaComent { get; set; }
        public virtual DbSet<TbPesquisaP> TbPesquisaP { get; set; }
        public virtual DbSet<TbPesquisaQ> TbPesquisaQ { get; set; }
        public virtual DbSet<TbPesquisaTipo> TbPesquisaTipo { get; set; }
        public virtual DbSet<TbPesquisaTitulo> TbPesquisaTitulo { get; set; }
        public virtual DbSet<TbProdutos> TbProdutos { get; set; }
        public virtual DbSet<TbProdutos1> TbProdutos1 { get; set; }
        public virtual DbSet<TbProdutosCategorias> TbProdutosCategorias { get; set; }
        public virtual DbSet<TbProdutosCategoriasArquivos> TbProdutosCategoriasArquivos { get; set; }
        public virtual DbSet<TbProdutosPastas> TbProdutosPastas { get; set; }
        public virtual DbSet<TbTransferenciaArquivos> TbTransferenciaArquivos { get; set; }
        public virtual DbSet<TbUpload> TbUpload { get; set; }
        public virtual DbSet<TbSolucao> TbSolucaos{ get; set; }
        public virtual DbSet<Estado> Estados{ get; set; }
        public virtual DbSet<Cidade> Cidades{ get; set; }

        public virtual DbSet<TbUsuarios> TbUsuarios { get; set; }
        public virtual DbSet<TbUsuarios1> TbUsuarios1 { get; set; }
        public virtual DbSet<TbUsuariosLog> TbUsuariosLog { get; set; }
        public virtual DbSet<TbUsuariosProdutos> TbUsuariosProdutos { get; set; }
        public virtual DbSet<Tokens> Tokens { get; set; }
        public virtual DbSet<UserDefault> UserDefault { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VEmpresaUsuarios> VEmpresaUsuarios { get; set; }
        public virtual DbSet<VUsuEmpresa> VUsuEmpresa { get; set; }
        public virtual DbSet<VUsuTurmaTreino> VUsuTurmaTreino { get; set; }
        public virtual DbSet<VUsuarioProduto> VUsuarioProduto { get; set; }
        public virtual DbSet<VwArquivos> VwArquivos { get; set; }
        public virtual DbSet<VwProdutos> VwProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=sqlserver01.datamace4.hospedagemdesites.ws;User id=datamace4;Password=Dtm@pv#6089;initial catalog=datamace4;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmAcoes>(entity =>
            {
                entity.Property(e => e.GuidAcao).ValueGeneratedNever();

                entity.Property(e => e.Descricao).IsUnicode(false);
            });

            modelBuilder.Entity<AdmArea>(entity =>
            {
                entity.Property(e => e.GuidArea).ValueGeneratedNever();

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<AdmUsuario>(entity =>
            {
                entity.Property(e => e.Customize).IsUnicode(false);

                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AdmUsuariosAreas>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<AdonisSchema>(entity =>
            {
                entity.Property(e => e.MigrationTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Avise>(entity =>
            {
                entity.Property(e => e.IdAvise).ValueGeneratedNever();

                entity.Property(e => e.Ddd).IsFixedLength();

                entity.Property(e => e.DddEmpresa).IsFixedLength();

                entity.Property(e => e.TelEmpresa).IsFixedLength();

                entity.Property(e => e.Telefone).IsFixedLength();

                entity.Property(e => e.Uf).IsFixedLength();
            });

            modelBuilder.Entity<CurEmpresas>(entity =>
            {


                entity.Property(e => e.Cnpj).IsUnicode(false);

                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ddd).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.RazaoSocial).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<CurInstrutor>(entity =>
            {
                entity.Property(e => e.Instrutor).IsUnicode(false);
            });

            modelBuilder.Entity<CurLocal>(entity =>
            {
                entity.Property(e => e.EmailRecebe).IsUnicode(false);

                entity.Property(e => e.Local).IsUnicode(false);
            });

            modelBuilder.Entity<CurTreinamento>(entity =>
            {
                entity.HasAlternateKey(x => x.IdTreinamento);

                entity.Property(e => e.CargaHoraria).IsUnicode(false);

                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdTreinamento).ValueGeneratedOnAdd();

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Sinopse).IsUnicode(false);
            });

            modelBuilder.Entity<CurTreinamentoCategoria>(entity =>
            {
                entity.Property(e => e.NomeCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<CurTreinamentoInteresse>(entity =>
            {
                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ddd).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Empresa).IsUnicode(false);

                entity.Property(e => e.Fone).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Uf).IsUnicode(false);
            });

            //modelBuilder.Entity<CurTurma>()
            //       .HasOne(p => p.CurTurmaGrupo)
            //       .WithMany(b => b.CurTurmas)
            //       .HasForeignKey(p => p.IdGrupo)
            //        .HasPrincipalKey(c => c.IdGrupo);

       

            modelBuilder.Entity<CurTurma>(entity =>
            {
                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                //entity.HasOne(p => p.CurTurmaGrupo).WithMany(b => b.CurTurmas).HasForeignKey(p => p.IdGrupo).HasPrincipalKey(c => c.IdGrupo);

                entity.Property(e => e.Periodo).IsUnicode(false);
            });

            modelBuilder.Entity<CurTurmaFase>(entity =>
            {
                entity.HasKey(e => new { e.IdTurma, e.IdFase });

#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                entity.HasIndex(e => e.IdFase)
                    .HasName("IX_curTurmaFase");
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
            });
 

            modelBuilder.Entity<CurTurmaGrupo>(entity =>
            {
                entity.Property(e => e.NomeGrupo).IsUnicode(false);

            });

            modelBuilder.Entity<CurUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ddd).IsUnicode(false);

                entity.Property(e => e.Ddd1).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Funcao).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Origem).IsUnicode(false);

                entity.Property(e => e.Rg).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<CurUsuariosTeste>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.Ddd).IsUnicode(false);

                entity.Property(e => e.Ddd1).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Funcao).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Origem).IsUnicode(false);

                entity.Property(e => e.Rg).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<CurUsuariosTurmas>(entity =>
            {
                entity.HasKey(e => new { e.IdTurma, e.IdUsuario });

                entity.Property(e => e.DataCriacao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Obs).IsUnicode(false);

                entity.Property(e => e.Resultado).IsUnicode(false);
            });

            modelBuilder.Entity<Dtproperties>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Property).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("images_property_id_foreign");
            });

            modelBuilder.Entity<MailControle>(entity =>
            {
                //entity.Property(e => e.IdControle).ValueGeneratedNever();

                entity.HasAlternateKey(x => x.IdControle);

            });

            modelBuilder.Entity<MailHistory>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<MailView>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<OrdersTeste>(entity =>
            {
                entity.HasAlternateKey(x => x.OrderId);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<Ordersteste1>(entity =>
            {
                entity.HasAlternateKey(x => x.OrderId);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatif8>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Estado).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf10>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Estado).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf11>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Estado).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf12>(entity =>
            {
                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.Ip).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf13>(entity =>
            {
                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.Ip).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf14>(entity =>
            {
                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.Ip).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf2>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Estado).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisf3>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf4>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf5>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf6>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf7>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf8>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<PesqSatisf9>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Estado).IsFixedLength();
            });

            modelBuilder.Entity<PesqSatisfExtra>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.EmpresaPerg1).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg2).IsUnicode(false);

                entity.Property(e => e.EmpresaPerg3).IsUnicode(false);

                entity.Property(e => e.Estado).IsFixedLength();

                entity.Property(e => e.IdCliente).IsUnicode(false);

                entity.Property(e => e.ProdutoComent1).IsUnicode(false);

                entity.Property(e => e.ProdutoComent2).IsUnicode(false);

                entity.Property(e => e.ProdutoComent3).IsUnicode(false);

                entity.Property(e => e.ProdutoComent4).IsUnicode(false);

                entity.Property(e => e.ProdutoComent5).IsUnicode(false);

                entity.Property(e => e.ProdutoComent6).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg1).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg2).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg3).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg4).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg5).IsUnicode(false);

                entity.Property(e => e.ProdutoPerg6).IsUnicode(false);

                entity.Property(e => e.VocePerg1).IsUnicode(false);

                entity.Property(e => e.VocePerg2).IsUnicode(false);

                entity.Property(e => e.VocePerg3).IsUnicode(false);

                entity.Property(e => e.VocePerg4).IsUnicode(false);
            });

            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("properties_user_id_foreign");
            });

            modelBuilder.Entity<Sra010>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.RaNome).IsUnicode(false);
            });

            modelBuilder.Entity<TbArquivos>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.TbArquivos)
                    .HasForeignKey(d => d.Categoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ARQUIVOS_TB_CATEGORIAS");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.TbArquivos)
                    .HasForeignKey(d => d.Produto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_ARQUIVOS_TB_PRODUTOS");
            });

            modelBuilder.Entity<TbArquivos1>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Descricao).IsUnicode(false);
            });

            modelBuilder.Entity<TbCasosSucesso>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasAlternateKey(x => x.IdCategoria);

                entity.Property(e => e.Descricao).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.NomePasta).IsUnicode(false);

                entity.Property(e => e.TipoDescricao).IsUnicode(false);

                entity.Property(e => e.TipoSigla)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbConhecimentos>(entity =>
            {
                entity.Property(e => e.Dataenvio).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TbContatos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.CtUf).IsFixedLength();
            });

            modelBuilder.Entity<TbEmpresaProdutos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresaUsuarios>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresaUsuariosPastas>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresaUsuariosProdutos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresas>(entity =>
            {
                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TbEmpresas1>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresasPastas>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresasPastasArquivos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEmpresasProdutos>(entity =>
            {
                modelBuilder.Entity<TbEmpresasProdutos>().HasKey(vf => new { vf.Empresa, vf.Produto });

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p.TbEmpresasProdutos)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_EMPRESAS_PRODUTOS_TB_EMPRESAS");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.TbEmpresasProdutos)
                    .HasForeignKey(d => d.Produto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_EMPRESAS_PRODUTOS_TB_PRODUTOS");
            });

            modelBuilder.Entity<TbEmpresasnova>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEnquete>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbEnqueteVotado>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbFaqInfo>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbFaqTipo>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbGerCliSub>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbGerenciador>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbGerenciadorCli>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbGerenciadorUsu>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });


            modelBuilder.Entity<TbNoticias>(entity =>
            {
                entity.HasAlternateKey(x => x.NotId);

                entity.Property(e => e.NotId).ValueGeneratedOnAdd();

                entity.Property(e => e.NotImagem).IsUnicode(false);
            });


            modelBuilder.Entity<TbNoticiasCategorias>(entity =>
            {
                entity.HasAlternateKey(x => x.NotIdCategoria);

                entity.Property(e => e.NomeCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<TbPesquicaC>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbPesquisaComent>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbPesquisaP>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbPesquisaQ>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbPesquisaTipo>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbPesquisaTitulo>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbSolucao>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbProdutos>(entity =>
            {
                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TbProdutos1>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Arquivo).IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutosCategorias>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Categoria).IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutosCategoriasArquivos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Arquivo).IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutosPastas>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbTransferenciaArquivos>(entity =>
            {
                entity.Property(e => e.Dataenvio).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DestinatarioNavigation)
                    .WithMany(p => p.TbTransferenciaArquivosDestinatarioNavigation)
                    .HasForeignKey(d => d.Destinatario)
                    .HasConstraintName("FK_TB_TRANSFERENCIA_ARQUIVOS_TB_USUARIOS1");

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.TbTransferenciaArquivos)
                    .HasForeignKey(d => d.Produto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_TRANSFERENCIA_ARQUIVOS_TB_PRODUTOS");

                entity.HasOne(d => d.RemetenteNavigation)
                    .WithMany(p => p.TbTransferenciaArquivosRemetenteNavigation)
                    .HasForeignKey(d => d.Remetente)
                    .HasConstraintName("FK_TB_TRANSFERENCIA_ARQUIVOS_TB_USUARIOS");
            });

            modelBuilder.Entity<TbUpload>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

            });

            modelBuilder.Entity<TbUsuarios>(entity =>
            {
                entity.Property(e => e.Nivel).HasDefaultValueSql("((2))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p.TbUsuarios)
                    .HasForeignKey(d => d.Empresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_USUARIOS_TB_EMPRESAS");
            });

            modelBuilder.Entity<TbUsuarios1>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<TbUsuariosLog>(entity =>
            {
                entity.HasKey(e => new { e.Usuario, e.Arquivo });


                entity.Property(e => e.Log).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.TbUsuariosLog)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_USUARIOS_LOG_TB_USUARIOS");
            });

            modelBuilder.Entity<TbUsuariosProdutos>(entity =>
            {
                modelBuilder.Entity<TbUsuariosProdutos>().HasKey(vf => new { vf.Produto });

                entity.HasOne(d => d.ProdutoNavigation)
                    .WithMany(p => p.TbUsuariosProdutos)
                    .HasForeignKey(d => d.Produto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_USUARIOS_PRODUTOS_TB_PRODUTOS");
            });

            modelBuilder.Entity<Tokens>(entity =>
            {
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                entity.HasIndex(e => e.Token)
                    .HasName("tokens_token_unique")
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
                    .IsUnique()
                    .HasFilter("([token] IS NOT NULL)");

                entity.Property(e => e.IsRevoked).HasDefaultValueSql("('0')");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("tokens_user_id_foreign");
            });

            modelBuilder.Entity<UserDefault>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });

            modelBuilder.Entity<Users>(entity =>
            {
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                entity.HasIndex(e => e.Email)
                    .HasName("users_email_unique")
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
                    .IsUnique()
                    .HasFilter("([email] IS NOT NULL)");

#pragma warning disable CS0618 // O tipo ou membro é obsoleto
                entity.HasIndex(e => e.Username)
                    .HasName("users_username_unique")
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
                    .IsUnique()
                    .HasFilter("([username] IS NOT NULL)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.UsuarioId).ValueGeneratedNever();
            });

            modelBuilder.Entity<VEmpresaUsuarios>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.ToView("v_empresa_usuarios");

                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.Ddd).IsUnicode(false);

                entity.Property(e => e.Ddd1).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Funcao).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.NomeEmpresa).IsUnicode(false);

                entity.Property(e => e.Origem).IsUnicode(false);

                entity.Property(e => e.Rg).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<VUsuEmpresa>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.ToView("v_usu_empresa");
            });

            modelBuilder.Entity<VUsuTurmaTreino>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.ToView("v_UsuTurmaTreino");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<VUsuarioProduto>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.ToView("v_usuario_produto");
            });

            modelBuilder.Entity<VwArquivos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.Property(e => e.Categoria).IsUnicode(false);

                entity.Property(e => e.Descricao).IsUnicode(false);

                entity.Property(e => e.NomePasta).IsUnicode(false);

                entity.Property(e => e.TipoDescricao).IsUnicode(false);

                entity.Property(e => e.TipoSigla)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwProdutos>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }


}
