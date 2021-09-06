using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDatamaceApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "admAcoes",
            //    columns: table => new
            //    {
            //        guidAcao = table.Column<Guid>(nullable: false),
            //        guidArea = table.Column<Guid>(nullable: false),
            //        Descricao = table.Column<string>(unicode: false, maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_admAcoes", x => x.guidAcao);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "admArea",
            //    columns: table => new
            //    {
            //        guidArea = table.Column<Guid>(nullable: false),
            //        Nome = table.Column<string>(unicode: false, maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_admArea", x => x.guidArea);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "admUsuario",
            //    columns: table => new
            //    {
            //        idUsuario = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(unicode: false, maxLength: 127, nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 256, nullable: false),
            //        Senha = table.Column<string>(unicode: false, fixedLength: true, maxLength: 40, nullable: true),
            //        Bloqueado = table.Column<bool>(nullable: false),
            //        SuperUsers = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        customize = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_admUsuario", x => x.idUsuario);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "admUsuariosAreas",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idUsuario = table.Column<int>(nullable: false),
            //        guidArea = table.Column<Guid>(nullable: false),
            //        guidAcao = table.Column<Guid>(nullable: true),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_admUsuariosAreas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "adonis_schema",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(maxLength: 255, nullable: true),
            //        batch = table.Column<int>(nullable: true),
            //        migration_time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_adonis_schema", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "avise",
            //    columns: table => new
            //    {
            //        id_avise = table.Column<int>(nullable: false),
            //        cpf = table.Column<string>(maxLength: 50, nullable: true),
            //        nome = table.Column<string>(maxLength: 50, nullable: true),
            //        email = table.Column<string>(maxLength: 50, nullable: true),
            //        ddd = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        telefone = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        funcao = table.Column<string>(maxLength: 50, nullable: true),
            //        cidade = table.Column<string>(maxLength: 50, nullable: true),
            //        uf = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        recebe_news = table.Column<int>(nullable: true),
            //        cnpj = table.Column<string>(maxLength: 50, nullable: true),
            //        razao_social = table.Column<string>(maxLength: 50, nullable: true),
            //        ddd_empresa = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        tel_empresa = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        id_curso = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_avise", x => x.id_avise);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curEmpresas",
            //    columns: table => new
            //    {
            //        idEmpresa = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(unicode: false, maxLength: 256, nullable: false),
            //        RazaoSocial = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
            //        DDD = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Telefone = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
            //        CNPJ = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        Cliente = table.Column<bool>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curEmpresas", x => x.idEmpresa);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curInstrutor",
            //    columns: table => new
            //    {
            //        idInstrutor = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Instrutor = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Descricao = table.Column<string>(type: "text", nullable: true),
            //        Ativo = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curInstrutor", x => x.idInstrutor);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curLocal",
            //    columns: table => new
            //    {
            //        idLocal = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Local = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Descricao = table.Column<string>(type: "text", nullable: true),
            //        emailRecebe = table.Column<string>(unicode: false, maxLength: 120, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curLocal", x => x.idLocal);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTreinamento",
            //    columns: table => new
            //    {
            //        idTreinamento = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(unicode: false, maxLength: 127, nullable: false),
            //        Sinopse = table.Column<string>(unicode: false, maxLength: 2548, nullable: true),
            //        Descricao = table.Column<string>(type: "text", nullable: true),
            //        Conteudo = table.Column<string>(type: "text", nullable: true),
            //        Preco = table.Column<double>(nullable: true),
            //        CargaHoraria = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
            //        Modulos = table.Column<int>(nullable: false),
            //        Tipo = table.Column<int>(nullable: false),
            //        Publicado = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        IdCategoria = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTreinamento", x => x.idTreinamento);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTreinamentoCategoria",
            //    columns: table => new
            //    {
            //        IdCategoria = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nomeCategoria = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTreinamentoCategoria", x => x.IdCategoria);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTreinamentoInteresse",
            //    columns: table => new
            //    {
            //        idInteresse = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        idTreinamento = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(unicode: false, maxLength: 128, nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 256, nullable: false),
            //        DDD = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Fone = table.Column<string>(unicode: false, maxLength: 18, nullable: true),
            //        Empresa = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
            //        UF = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
            //        Contato = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTreinamentoInteresse", x => x.idInteresse);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTurma",
            //    columns: table => new
            //    {
            //        idTurma = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        idTreinamento = table.Column<int>(nullable: false),
            //        idGrupo = table.Column<int>(nullable: true),
            //        idLocal = table.Column<int>(nullable: true),
            //        idInstrutor = table.Column<int>(nullable: true),
            //        Observacao = table.Column<string>(type: "text", nullable: true),
            //        Preco = table.Column<double>(nullable: true),
            //        Vagas = table.Column<int>(nullable: false),
            //        Periodo = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        Modulo = table.Column<int>(nullable: false),
            //        Aberta = table.Column<bool>(nullable: false),
            //        Publicado = table.Column<bool>(nullable: false),
            //        DataInicio = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DataFinal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTurma", x => x.idTurma);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTurmaFase",
            //    columns: table => new
            //    {
            //        idTurma = table.Column<int>(nullable: false),
            //        idFase = table.Column<int>(nullable: false),
            //        Data = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTurmaFase", x => new { x.idTurma, x.idFase });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curTurmaGrupo",
            //    columns: table => new
            //    {
            //        idGrupo = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NomeGrupo = table.Column<string>(unicode: false, maxLength: 24, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curTurmaGrupo", x => x.idGrupo);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curUsuarios",
            //    columns: table => new
            //    {
            //        idUsuario = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        idEmpresa = table.Column<int>(nullable: true),
            //        Nome = table.Column<string>(unicode: false, maxLength: 127, nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
            //        Senha = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
            //        CPF = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        RG = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        DDD = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Telefone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        Funcao = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
            //        Cidade = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Estado = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
            //        DesejaNews = table.Column<bool>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        DDD1 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Celular = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        origem = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curUsuarios", x => x.idUsuario);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curUsuarios_teste",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idUsuario = table.Column<int>(nullable: false),
            //        idEmpresa = table.Column<int>(nullable: true),
            //        Nome = table.Column<string>(unicode: false, maxLength: 127, nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 256, nullable: true),
            //        Senha = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
            //        CPF = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        RG = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        DDD = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Telefone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        Funcao = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
            //        Cidade = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Estado = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
            //        DesejaNews = table.Column<bool>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
            //        DDD1 = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
            //        Celular = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
            //        origem = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curUsuarios_teste", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "curUsuariosTurmas",
            //    columns: table => new
            //    {
            //        idTurma = table.Column<int>(nullable: false),
            //        idUsuario = table.Column<int>(nullable: false),
            //        Aprovado = table.Column<bool>(nullable: false),
            //        Pago = table.Column<bool>(nullable: false),
            //        Presente = table.Column<bool>(nullable: false),
            //        Resultado = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
            //        Obs = table.Column<string>(unicode: false, maxLength: 2048, nullable: true),
            //        DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_curUsuariosTurmas", x => new { x.idTurma, x.idUsuario });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "dtproperties",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        property = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
            //        objectid = table.Column<int>(nullable: true),
            //        value = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
            //        uvalue = table.Column<string>(maxLength: 255, nullable: true),
            //        lvalue = table.Column<byte[]>(type: "image", nullable: true),
            //        version = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_dtproperties", x => new { x.id, x.property });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Estado",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodigoUf = table.Column<int>(nullable: false),
            //        Regiao = table.Column<int>(nullable: false),
            //        Uf = table.Column<string>(maxLength: 2, nullable: true),
            //        Nome = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Estado", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "evento",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        nome = table.Column<string>(maxLength: 50, nullable: true),
            //        descricao = table.Column<string>(maxLength: 255, nullable: true),
            //        status = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_evento", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lembrete",
            //    columns: table => new
            //    {
            //        id_lembrete = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nome = table.Column<string>(nullable: true),
            //        descricao = table.Column<string>(type: "text", nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        status = table.Column<int>(nullable: true),
            //        ordem = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lembrete", x => x.id_lembrete);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mail_controle",
            //    columns: table => new
            //    {
            //        id_controle = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        conteudo = table.Column<string>(type: "text", nullable: true),
            //        usuario_remetente = table.Column<string>(maxLength: 2000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email_destinatario = table.Column<string>(type: "text", nullable: true),
            //        enviado = table.Column<string>(maxLength: 2000, nullable: true),
            //        template = table.Column<string>(maxLength: 2000, nullable: true),
            //        tema = table.Column<string>(maxLength: 2000, nullable: true),
            //        remetente = table.Column<string>(maxLength: 2000, nullable: true),
            //        produto = table.Column<string>(maxLength: 2000, nullable: true),
            //        curso = table.Column<string>(maxLength: 2000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_mail_controle", x => x.id_controle);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailCampanhas",
            //    columns: table => new
            //    {
            //        CampanhaID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Titulo = table.Column<string>(maxLength: 50, nullable: true),
            //        Conteudo = table.Column<string>(type: "text", nullable: true),
            //        Grupo = table.Column<string>(maxLength: 100, nullable: true),
            //        DataProgramada = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Ativo = table.Column<bool>(nullable: true),
            //        TotalEnviado = table.Column<int>(nullable: true),
            //        TotalErro = table.Column<int>(nullable: true),
            //        TotalRetornado = table.Column<int>(nullable: true),
            //        TotalLido = table.Column<int>(nullable: true),
            //        TotalVisitas = table.Column<int>(nullable: true),
            //        TotalCompras = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailCampanhas", x => x.CampanhaID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailContas",
            //    columns: table => new
            //    {
            //        ContaID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Titulo = table.Column<string>(maxLength: 50, nullable: true),
            //        FromName = table.Column<string>(maxLength: 50, nullable: true),
            //        FromMail = table.Column<string>(maxLength: 50, nullable: true),
            //        smtpServer = table.Column<string>(maxLength: 50, nullable: true),
            //        smtpLogin = table.Column<string>(maxLength: 50, nullable: true),
            //        smtpPassword = table.Column<string>(maxLength: 50, nullable: true),
            //        portSMTP = table.Column<int>(nullable: true),
            //        sslSMTP = table.Column<bool>(nullable: true),
            //        LimiteDiario = table.Column<int>(nullable: true),
            //        Ativo = table.Column<bool>(nullable: true),
            //        Dominios = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailContas", x => x.ContaID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailEmails",
            //    columns: table => new
            //    {
            //        Email = table.Column<string>(maxLength: 100, nullable: false),
            //        Grupo = table.Column<string>(maxLength: 100, nullable: true),
            //        LastSend = table.Column<int>(nullable: true),
            //        TotalSend = table.Column<int>(nullable: true),
            //        Visitas = table.Column<int>(nullable: true),
            //        Compras = table.Column<int>(nullable: true),
            //        Erros = table.Column<int>(nullable: true),
            //        Erro = table.Column<string>(maxLength: 250, nullable: true),
            //        Ativo = table.Column<bool>(nullable: true),
            //        ContaID = table.Column<int>(nullable: true),
            //        DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailEmails", x => x.Email);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailGrupos",
            //    columns: table => new
            //    {
            //        GrupoID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Descricao = table.Column<string>(maxLength: 50, nullable: true),
            //        Total = table.Column<int>(nullable: true),
            //        Funcao = table.Column<string>(maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailGrupos", x => x.GrupoID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailHistory",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        Data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email = table.Column<string>(maxLength: 50, nullable: true),
            //        CampanhaID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailHistory", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MailView",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        Data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email = table.Column<string>(maxLength: 50, nullable: true),
            //        CampanhaID = table.Column<int>(nullable: true),
            //        template = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MailView", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Municipio",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Codigo = table.Column<int>(nullable: false),
            //        Uf = table.Column<string>(maxLength: 2, nullable: true),
            //        Nome = table.Column<string>(maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Municipio", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        OrderId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        OrderDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.OrderId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Orders_teste",
            //    columns: table => new
            //    {
            //        OrderId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        OrderDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders_teste", x => x.OrderId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ordersteste",
            //    columns: table => new
            //    {
            //        OrderId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        OrderDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ordersteste", x => x.OrderId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satif_8",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satif_8", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_10",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        produto_perg7 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg8 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment7 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment8 = table.Column<string>(maxLength: 1000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_10", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_11",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        produto_perg7 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg8 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment7 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment8 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_perg9 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment9 = table.Column<string>(maxLength: 1000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_11", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_12",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg7 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg8 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg9 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment7 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment8 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment9 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<string>(maxLength: 50, nullable: true),
            //        data1 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        ip = table.Column<string>(fixedLength: true, maxLength: 20, nullable: true),
            //        navegador = table.Column<string>(maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_12", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_13",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg7 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg8 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg9 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment7 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment8 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment9 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<string>(maxLength: 50, nullable: true),
            //        data1 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        ip = table.Column<string>(fixedLength: true, maxLength: 20, nullable: true),
            //        navegador = table.Column<string>(maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_13", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_14",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg7 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg8 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg9 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment7 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment8 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment9 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<string>(maxLength: 50, nullable: true),
            //        data1 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        ip = table.Column<string>(fixedLength: true, maxLength: 20, nullable: true),
            //        navegador = table.Column<string>(maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_14", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_2",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_2", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_3",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_3", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_4",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_4", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_5",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_5", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_6",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_6", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_7",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_7", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_8",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_8", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_9",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_pesq = table.Column<int>(nullable: false),
            //        voce_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_9", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "pesq_satisf_extra",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        voce_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        voce_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg4 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg5 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_perg6 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        produto_coment1 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment2 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment3 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment4 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment5 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        produto_coment6 = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        estado = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        id_cliente = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        empresa_perg3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        text = table.Column<string>(type: "text", nullable: true),
            //        id_pesq = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pesq_satisf_extra", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SRA010",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        Matricula = table.Column<int>(nullable: true),
            //        RA_NOME = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        RA_ADMISSA = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SRA010", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_CATEGORIAS",
            //    columns: table => new
            //    {
            //        CATEGORIA = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NOME = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_CATEGORIAS", x => x.CATEGORIA);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_CONHECIMENTOS",
            //    columns: table => new
            //    {
            //        CONHECIMENTO = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CONTATO = table.Column<string>(maxLength: 50, nullable: false),
            //        TEMA = table.Column<string>(maxLength: 100, nullable: false),
            //        TELEFONE = table.Column<string>(maxLength: 50, nullable: true),
            //        COMENTARIOS = table.Column<string>(maxLength: 250, nullable: true),
            //        REMETENTE = table.Column<string>(maxLength: 100, nullable: false),
            //        ARQUIVO = table.Column<string>(maxLength: 100, nullable: false),
            //        DATAENVIO = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
            //        STATUS = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_CONHECIMENTOS", x => x.CONHECIMENTO);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_EMPRESAS",
            //    columns: table => new
            //    {
            //        EMPRESA = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NOME = table.Column<string>(maxLength: 100, nullable: false),
            //        CODIGO = table.Column<string>(maxLength: 7, nullable: true),
            //        CNPJ = table.Column<string>(maxLength: 20, nullable: true),
            //        RESPONSAVEL = table.Column<string>(maxLength: 150, nullable: true),
            //        EMAIL = table.Column<string>(maxLength: 250, nullable: true),
            //        DDD = table.Column<string>(maxLength: 3, nullable: true),
            //        FONE = table.Column<string>(maxLength: 50, nullable: true),
            //        DATA_CADASTRO = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
            //        STATUS = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
            //        CIDADE = table.Column<string>(maxLength: 50, nullable: true),
            //        UF = table.Column<string>(maxLength: 2, nullable: true),
            //        ATIVADO = table.Column<bool>(nullable: true),
            //        Cliente = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_EMPRESAS", x => x.EMPRESA);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_EMPRESASNova",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        EMPRESA = table.Column<int>(nullable: false),
            //        NOME = table.Column<string>(maxLength: 100, nullable: false),
            //        CODIGO = table.Column<string>(maxLength: 7, nullable: true),
            //        CNPJ = table.Column<string>(maxLength: 20, nullable: true),
            //        RESPONSAVEL = table.Column<string>(maxLength: 150, nullable: true),
            //        EMAIL = table.Column<string>(maxLength: 250, nullable: true),
            //        DDD = table.Column<string>(maxLength: 3, nullable: true),
            //        FONE = table.Column<string>(maxLength: 50, nullable: true),
            //        DATA_CADASTRO = table.Column<DateTime>(type: "smalldatetime", nullable: false),
            //        STATUS = table.Column<bool>(nullable: false),
            //        CIDADE = table.Column<string>(maxLength: 50, nullable: true),
            //        UF = table.Column<string>(maxLength: 2, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_EMPRESASNova", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tb_enquete",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idEnquete = table.Column<int>(nullable: false),
            //        id_tipo = table.Column<int>(nullable: false),
            //        Enquete = table.Column<string>(maxLength: 255, nullable: false),
            //        resp1 = table.Column<int>(nullable: false),
            //        resp2 = table.Column<int>(nullable: false),
            //        resp3 = table.Column<int>(nullable: false),
            //        resp4 = table.Column<int>(nullable: false),
            //        comentario = table.Column<string>(maxLength: 255, nullable: false),
            //        status = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tb_enquete", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_PRODUTOS",
            //    columns: table => new
            //    {
            //        PRODUTO = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NOME = table.Column<string>(maxLength: 50, nullable: false),
            //        STATUS = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_PRODUTOS", x => x.PRODUTO);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbArquivos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdArquivo = table.Column<int>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false),
            //        IdCategoria = table.Column<int>(nullable: false),
            //        NomeFisico = table.Column<string>(maxLength: 100, nullable: false),
            //        Descricao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
            //        Tamanho = table.Column<int>(nullable: true),
            //        Downloads = table.Column<int>(nullable: false),
            //        Status = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbArquivos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbCasosSucesso",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        casId = table.Column<int>(nullable: false),
            //        castitulo = table.Column<string>(maxLength: 150, nullable: true),
            //        casResumo = table.Column<string>(maxLength: 150, nullable: true),
            //        casTexto = table.Column<string>(type: "ntext", nullable: true),
            //        casData = table.Column<string>(maxLength: 50, nullable: true),
            //        casFonte = table.Column<string>(maxLength: 100, nullable: true),
            //        casStatus = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbCasosSucesso", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbCategoria",
            //    columns: table => new
            //    {
            //        IdCategoria = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        Descricao = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
            //        TipoSigla = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
            //        TipoDescricao = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        NomePasta = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Ativo = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbCategoria", x => x.IdCategoria);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbContatos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        ctId = table.Column<int>(nullable: false),
            //        ctNome = table.Column<string>(maxLength: 200, nullable: true),
            //        ctDDD = table.Column<string>(maxLength: 3, nullable: true),
            //        ctFone = table.Column<string>(maxLength: 50, nullable: true),
            //        ctEndereco = table.Column<string>(maxLength: 250, nullable: true),
            //        ctCidade = table.Column<string>(maxLength: 50, nullable: true),
            //        ctUF = table.Column<string>(fixedLength: true, maxLength: 2, nullable: true),
            //        ctBairro = table.Column<string>(maxLength: 50, nullable: true),
            //        ctCEP = table.Column<string>(maxLength: 10, nullable: true),
            //        ctEmail = table.Column<string>(maxLength: 150, nullable: true),
            //        ctMsg = table.Column<string>(type: "ntext", nullable: true),
            //        ctData = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        ctStatus = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbContatos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresa_Produtos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        epProId = table.Column<int>(nullable: false),
            //        epId = table.Column<int>(nullable: true),
            //        proId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresa_Produtos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresa_Usuarios",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        euId = table.Column<int>(nullable: false),
            //        euEpId = table.Column<int>(nullable: true),
            //        euNome = table.Column<string>(maxLength: 100, nullable: true),
            //        euEmail = table.Column<string>(maxLength: 100, nullable: true),
            //        euSenha = table.Column<string>(maxLength: 100, nullable: true),
            //        euNivel = table.Column<int>(nullable: true),
            //        euStatus = table.Column<bool>(nullable: true),
            //        euCargo = table.Column<string>(maxLength: 50, nullable: true),
            //        euFone = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresa_Usuarios", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbEmpresa_Usuarios_Pastas",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdEmpresaUsuarioPasta = table.Column<int>(nullable: false),
            //        IdUsuario = table.Column<int>(nullable: true),
            //        IdPasta = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbEmpresa_Usuarios_Pastas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresa_Usuarios_Produtos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProdutoUsuario = table.Column<int>(nullable: false),
            //        IdUsuario = table.Column<int>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresa_Usuarios_Produtos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresas",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        epId = table.Column<int>(nullable: false),
            //        epRazao = table.Column<string>(maxLength: 255, nullable: true),
            //        epStatus = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresasPastas",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdEmpresaPasta = table.Column<int>(nullable: false),
            //        IdEmpresa = table.Column<int>(nullable: true),
            //        IdPastaPai = table.Column<int>(nullable: true),
            //        IdUsuario = table.Column<int>(nullable: true),
            //        Nome = table.Column<string>(maxLength: 50, nullable: true),
            //        Descricao = table.Column<string>(maxLength: 500, nullable: true),
            //        Status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresasPastas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEmpresasPastasArquivos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdClientePastaArquivo = table.Column<int>(nullable: false),
            //        IdPasta = table.Column<int>(nullable: true),
            //        NomeArquivo = table.Column<string>(maxLength: 250, nullable: false),
            //        Tamanho = table.Column<int>(nullable: false),
            //        Downloads = table.Column<int>(nullable: true),
            //        Status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEmpresasPastasArquivos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbEnqueteVotado",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_usuario = table.Column<int>(nullable: true),
            //        id_pesquisa = table.Column<int>(nullable: true),
            //        votacao = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbEnqueteVotado", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbFaqInfo",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        fiId = table.Column<int>(nullable: false),
            //        fiFTID = table.Column<int>(nullable: true),
            //        fiPerg = table.Column<string>(maxLength: 250, nullable: true),
            //        fiResp = table.Column<string>(type: "ntext", nullable: true),
            //        fiStatus = table.Column<byte>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbFaqInfo", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbFaqTipo",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        ftId = table.Column<int>(nullable: false),
            //        ftSite = table.Column<string>(maxLength: 50, nullable: true),
            //        ftNome = table.Column<string>(maxLength: 200, nullable: true),
            //        ftStatus = table.Column<byte>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbFaqTipo", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbGerCliSub",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idSub_pasta = table.Column<int>(nullable: false),
            //        idempresa = table.Column<int>(nullable: true),
            //        idusuario = table.Column<int>(nullable: true),
            //        idPasta = table.Column<int>(nullable: true),
            //        nome = table.Column<string>(maxLength: 100, nullable: true),
            //        descricao = table.Column<string>(type: "ntext", nullable: true),
            //        status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbGerCliSub", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbGerenciador",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idGerenciador = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(maxLength: 100, nullable: true),
            //        descricao = table.Column<string>(type: "ntext", nullable: true),
            //        idproduto = table.Column<int>(nullable: true),
            //        status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbGerenciador", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbGerenciadorCli",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idGerenciadorCli = table.Column<int>(nullable: false),
            //        idempresa = table.Column<int>(nullable: true),
            //        idusuario = table.Column<int>(nullable: true),
            //        nome = table.Column<string>(maxLength: 100, nullable: true),
            //        descricao = table.Column<string>(type: "ntext", nullable: true),
            //        status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbGerenciadorCli", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbGerenciadorUsu",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idGerenciadorUsu = table.Column<int>(nullable: false),
            //        idempresa = table.Column<int>(nullable: true),
            //        idusuario = table.Column<int>(nullable: true),
            //        nome = table.Column<string>(maxLength: 100, nullable: true),
            //        descricao = table.Column<string>(type: "ntext", nullable: true),
            //        status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbGerenciadorUsu", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbNoticias",
            //    columns: table => new
            //    {
            //        NotId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NotTitulo = table.Column<string>(maxLength: 255, nullable: true),
            //        NotResenha = table.Column<string>(maxLength: 255, nullable: true),
            //        NotConteudo = table.Column<string>(type: "ntext", nullable: true),
            //        NotFonte = table.Column<string>(maxLength: 250, nullable: true),
            //        NotImagem = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        NotComentario = table.Column<string>(maxLength: 50, nullable: true),
            //        NotVigenciaInicio = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        NotVigenciaFim = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        NotDataCadastro = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        NotStatus = table.Column<bool>(nullable: true),
            //        NotIdCategoria = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbNoticias", x => x.NotId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbNoticiasCategorias",
            //    columns: table => new
            //    {
            //        NotIdCategoria = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NomeCategoria = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbNoticiasCategorias", x => x.NotIdCategoria);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquicaC",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idCliente = table.Column<int>(nullable: false),
            //        idPesquisaP = table.Column<int>(nullable: true),
            //        DataGrava = table.Column<DateTime>(type: "datetime", nullable: true),
            //        observacao = table.Column<string>(type: "ntext", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquicaC", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquisaComent",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        id_Coment = table.Column<int>(nullable: false),
            //        idUsuario = table.Column<int>(nullable: true),
            //        idPesquisaTipo = table.Column<int>(nullable: true),
            //        idPesquisaTitulo = table.Column<int>(nullable: true),
            //        idPesquisaEnquete = table.Column<int>(nullable: true),
            //        Comente = table.Column<string>(type: "ntext", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquisaComent", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquisaP",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idPesquisaPerg = table.Column<int>(nullable: false),
            //        idPesquisaTipo = table.Column<int>(nullable: true),
            //        idPesquisaT = table.Column<int>(nullable: true),
            //        idtop = table.Column<int>(nullable: true),
            //        pesquisatexto = table.Column<string>(type: "ntext", nullable: true),
            //        comente = table.Column<string>(type: "ntext", nullable: true),
            //        comenteStatus = table.Column<int>(nullable: true),
            //        status = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquisaP", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquisaQ",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idquestao = table.Column<int>(nullable: false),
            //        idPesquisaTipo = table.Column<int>(nullable: true),
            //        idPesquisaT = table.Column<int>(nullable: true),
            //        idPesquisaP = table.Column<int>(nullable: true),
            //        questao = table.Column<string>(maxLength: 250, nullable: true),
            //        resultado = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquisaQ", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquisaTipo",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idNome = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(maxLength: 100, nullable: true),
            //        DataInicio = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DataFim = table.Column<DateTime>(type: "datetime", nullable: true),
            //        txtCab = table.Column<string>(type: "ntext", nullable: true),
            //        txtRod = table.Column<string>(type: "ntext", nullable: true),
            //        image = table.Column<string>(maxLength: 255, nullable: true),
            //        status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquisaTipo", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbPesquisaTitulo",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idPesquisaT = table.Column<int>(nullable: false),
            //        idPesquisaTipo = table.Column<int>(nullable: true),
            //        Titulo = table.Column<string>(type: "ntext", nullable: true),
            //        observacao = table.Column<string>(type: "ntext", nullable: true),
            //        status = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbPesquisaTitulo", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbProdutos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(maxLength: 200, nullable: true),
            //        Arquivo = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
            //        Status = table.Column<bool>(nullable: true),
            //        DtUpload = table.Column<DateTime>(type: "datetime", nullable: true),
            //        UserUltimoDown = table.Column<int>(nullable: true),
            //        DtUltimoDown = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DtInclusao = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbProdutos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbProdutosCategorias",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProdCategoria = table.Column<int>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false),
            //        Categoria = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        Status = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbProdutosCategorias", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbProdutosCategoriasArquivos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProdCatArquivo = table.Column<int>(nullable: false),
            //        IdCategoria = table.Column<int>(nullable: false),
            //        Arquivo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Tamanho = table.Column<int>(nullable: false),
            //        Status = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbProdutosCategoriasArquivos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TbProdutosPastas",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProdutoPasta = table.Column<int>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: true),
            //        IdPastaPai = table.Column<int>(nullable: true),
            //        Nome = table.Column<string>(maxLength: 50, nullable: true),
            //        Descricao = table.Column<string>(maxLength: 500, nullable: true),
            //        Status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TbProdutosPastas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbsolucao",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        slug = table.Column<string>(maxLength: 250, nullable: false),
            //        menu = table.Column<string>(maxLength: 250, nullable: false),
            //        titulo = table.Column<string>(maxLength: 250, nullable: false),
            //        imagePath = table.Column<string>(maxLength: 250, nullable: true),
            //        parent = table.Column<bool>(nullable: false),
            //        conteudo = table.Column<string>(type: "ntext", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbsolucao", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbUpload",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        idupload = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(maxLength: 100, nullable: true),
            //        descricao = table.Column<string>(type: "ntext", nullable: true),
            //        idempresa = table.Column<int>(nullable: true),
            //        idUsuario = table.Column<int>(nullable: true),
            //        idPasta = table.Column<int>(nullable: true),
            //        idSubPasta = table.Column<int>(nullable: true),
            //        contador = table.Column<int>(nullable: true),
            //        data = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Status = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbUpload", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbUsuarios",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        usId = table.Column<int>(nullable: false),
            //        usLogin = table.Column<string>(maxLength: 50, nullable: true),
            //        usSenha = table.Column<string>(maxLength: 50, nullable: true),
            //        usTipo = table.Column<int>(nullable: true),
            //        usAreas = table.Column<string>(maxLength: 50, nullable: true),
            //        usStatus = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbUsuarios", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserDefault",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        UserID = table.Column<int>(nullable: true),
            //        KeyRef = table.Column<string>(maxLength: 50, nullable: true),
            //        KeyValue = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserDefault", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "users",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        username = table.Column<string>(maxLength: 80, nullable: false),
            //        email = table.Column<string>(maxLength: 254, nullable: false),
            //        password = table.Column<string>(maxLength: 60, nullable: false),
            //        created_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //        updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_users", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Usuarios",
            //    columns: table => new
            //    {
            //        UsuarioID = table.Column<int>(nullable: false),
            //        Usuario = table.Column<string>(maxLength: 50, nullable: true),
            //        Senha = table.Column<string>(maxLength: 50, nullable: true),
            //        Nome = table.Column<string>(maxLength: 50, nullable: true),
            //        Administrador = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VwArquivos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdArquivo = table.Column<int>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false),
            //        IdCategoria = table.Column<int>(nullable: false),
            //        NomeFisico = table.Column<string>(maxLength: 100, nullable: false),
            //        Descricao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
            //        Tamanho = table.Column<int>(nullable: true),
            //        Downloads = table.Column<int>(nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        Produto = table.Column<string>(maxLength: 200, nullable: false),
            //        Categoria = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        TipoSigla = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
            //        TipoDescricao = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        NomePasta = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VwArquivos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VwProdutos",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        IdProduto = table.Column<int>(nullable: false),
            //        Nome = table.Column<string>(maxLength: 200, nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        QtdeArquivos = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VwProdutos", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_USUARIOS",
            //    columns: table => new
            //    {
            //        USUARIO = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EMPRESA = table.Column<int>(nullable: false),
            //        NOME = table.Column<string>(maxLength: 100, nullable: false),
            //        EMAIL = table.Column<string>(maxLength: 500, nullable: false),
            //        LOGIN = table.Column<string>(maxLength: 50, nullable: true),
            //        SENHA = table.Column<string>(maxLength: 50, nullable: false),
            //        CARGO = table.Column<string>(maxLength: 50, nullable: true),
            //        DDD = table.Column<string>(maxLength: 5, nullable: true),
            //        FONE = table.Column<string>(maxLength: 50, nullable: true),
            //        NIVEL = table.Column<byte>(nullable: false, defaultValueSql: "((2))"),
            //        STATUS = table.Column<byte>(nullable: true, defaultValueSql: "((1))"),
            //        CIDADE = table.Column<string>(maxLength: 50, nullable: true),
            //        UF = table.Column<string>(maxLength: 2, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_USUARIOS", x => x.USUARIO);
            //        table.ForeignKey(
            //            name: "FK_TB_USUARIOS_TB_EMPRESAS",
            //            column: x => x.EMPRESA,
            //            principalTable: "TB_EMPRESAS",
            //            principalColumn: "EMPRESA",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_ARQUIVOS",
            //    columns: table => new
            //    {
            //        ARQUIVO = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PRODUTO = table.Column<int>(nullable: false),
            //        CATEGORIA = table.Column<int>(nullable: false),
            //        NOME = table.Column<string>(maxLength: 50, nullable: false),
            //        DESCRICAO = table.Column<string>(maxLength: 250, nullable: true),
            //        STATUS = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_ARQUIVOS", x => x.ARQUIVO);
            //        table.ForeignKey(
            //            name: "FK_TB_ARQUIVOS_TB_CATEGORIAS",
            //            column: x => x.CATEGORIA,
            //            principalTable: "TB_CATEGORIAS",
            //            principalColumn: "CATEGORIA",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_TB_ARQUIVOS_TB_PRODUTOS",
            //            column: x => x.PRODUTO,
            //            principalTable: "TB_PRODUTOS",
            //            principalColumn: "PRODUTO",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_EMPRESAS_PRODUTOS",
            //    columns: table => new
            //    {
            //        EMPRESA = table.Column<int>(nullable: false),
            //        PRODUTO = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_EMPRESAS_PRODUTOS", x => new { x.EMPRESA, x.PRODUTO });
            //        table.ForeignKey(
            //            name: "FK_TB_EMPRESAS_PRODUTOS_TB_EMPRESAS",
            //            column: x => x.EMPRESA,
            //            principalTable: "TB_EMPRESAS",
            //            principalColumn: "EMPRESA",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_TB_EMPRESAS_PRODUTOS_TB_PRODUTOS",
            //            column: x => x.PRODUTO,
            //            principalTable: "TB_PRODUTOS",
            //            principalColumn: "PRODUTO",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_USUARIOS_PRODUTOS",
            //    columns: table => new
            //    {
            //        PRODUTO = table.Column<int>(nullable: false),
            //        USUARIO = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_USUARIOS_PRODUTOS", x => x.PRODUTO);
            //        table.ForeignKey(
            //            name: "FK_TB_USUARIOS_PRODUTOS_TB_PRODUTOS",
            //            column: x => x.PRODUTO,
            //            principalTable: "TB_PRODUTOS",
            //            principalColumn: "PRODUTO",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "properties",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        user_id = table.Column<int>(nullable: true),
            //        title = table.Column<string>(maxLength: 255, nullable: false),
            //        address = table.Column<string>(maxLength: 255, nullable: false),
            //        price = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
            //        latitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false),
            //        longitude = table.Column<decimal>(type: "decimal(9, 6)", nullable: false),
            //        created_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //        updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_properties", x => x.id);
            //        table.ForeignKey(
            //            name: "properties_user_id_foreign",
            //            column: x => x.user_id,
            //            principalTable: "users",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tokens",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        user_id = table.Column<int>(nullable: true),
            //        token = table.Column<string>(maxLength: 255, nullable: false),
            //        type = table.Column<string>(maxLength: 80, nullable: false),
            //        is_revoked = table.Column<bool>(nullable: true, defaultValueSql: "('0')"),
            //        created_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //        updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tokens", x => x.id);
            //        table.ForeignKey(
            //            name: "tokens_user_id_foreign",
            //            column: x => x.user_id,
            //            principalTable: "users",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_TRANSFERENCIA_ARQUIVOS",
            //    columns: table => new
            //    {
            //        TRANSFERENCIA = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        REMETENTE = table.Column<int>(nullable: true),
            //        DESTINATARIO = table.Column<int>(nullable: true),
            //        PARA = table.Column<string>(maxLength: 100, nullable: true),
            //        EMAIL = table.Column<string>(maxLength: 100, nullable: false),
            //        ASSUNTO = table.Column<string>(maxLength: 100, nullable: false),
            //        COMENTARIOS = table.Column<string>(maxLength: 250, nullable: true),
            //        ARQUIVO = table.Column<string>(maxLength: 50, nullable: false),
            //        PRODUTO = table.Column<int>(nullable: true),
            //        idEmpresa = table.Column<int>(nullable: true),
            //        idUsuario = table.Column<int>(nullable: true),
            //        DATAENVIO = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
            //        STATUS = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_TRANSFERENCIA_ARQUIVOS", x => x.TRANSFERENCIA);
            //        table.ForeignKey(
            //            name: "FK_TB_TRANSFERENCIA_ARQUIVOS_TB_USUARIOS1",
            //            column: x => x.DESTINATARIO,
            //            principalTable: "TB_USUARIOS",
            //            principalColumn: "USUARIO",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_TB_TRANSFERENCIA_ARQUIVOS_TB_PRODUTOS",
            //            column: x => x.PRODUTO,
            //            principalTable: "TB_PRODUTOS",
            //            principalColumn: "PRODUTO",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_TB_TRANSFERENCIA_ARQUIVOS_TB_USUARIOS",
            //            column: x => x.REMETENTE,
            //            principalTable: "TB_USUARIOS",
            //            principalColumn: "USUARIO",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TB_USUARIOS_LOG",
            //    columns: table => new
            //    {
            //        USUARIO = table.Column<int>(nullable: false),
            //        ARQUIVO = table.Column<int>(nullable: false),
            //        LOG = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
            //        IP = table.Column<string>(maxLength: 15, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TB_USUARIOS_LOG", x => new { x.USUARIO, x.ARQUIVO });
            //        table.ForeignKey(
            //            name: "FK_TB_USUARIOS_LOG_TB_USUARIOS",
            //            column: x => x.USUARIO,
            //            principalTable: "TB_USUARIOS",
            //            principalColumn: "USUARIO",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "images",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        property_id = table.Column<int>(nullable: true),
            //        path = table.Column<string>(maxLength: 255, nullable: false),
            //        created_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //        updated_at = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_images", x => x.id);
            //        table.ForeignKey(
            //            name: "images_property_id_foreign",
            //            column: x => x.property_id,
            //            principalTable: "properties",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_curTurmaFase",
            //    table: "curTurmaFase",
            //    column: "idFase");

            //migrationBuilder.CreateIndex(
            //    name: "IX_images_property_id",
            //    table: "images",
            //    column: "property_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_properties_user_id",
            //    table: "properties",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_ARQUIVOS_CATEGORIA",
            //    table: "TB_ARQUIVOS",
            //    column: "CATEGORIA");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_ARQUIVOS_PRODUTO",
            //    table: "TB_ARQUIVOS",
            //    column: "PRODUTO");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_EMPRESAS_PRODUTOS_PRODUTO",
            //    table: "TB_EMPRESAS_PRODUTOS",
            //    column: "PRODUTO");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_TRANSFERENCIA_ARQUIVOS_DESTINATARIO",
            //    table: "TB_TRANSFERENCIA_ARQUIVOS",
            //    column: "DESTINATARIO");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_TRANSFERENCIA_ARQUIVOS_PRODUTO",
            //    table: "TB_TRANSFERENCIA_ARQUIVOS",
            //    column: "PRODUTO");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_TRANSFERENCIA_ARQUIVOS_REMETENTE",
            //    table: "TB_TRANSFERENCIA_ARQUIVOS",
            //    column: "REMETENTE");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TB_USUARIOS_EMPRESA",
            //    table: "TB_USUARIOS",
            //    column: "EMPRESA");

            //migrationBuilder.CreateIndex(
            //    name: "tokens_token_unique",
            //    table: "tokens",
            //    column: "token",
            //    unique: true,
            //    filter: "([token] IS NOT NULL)");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tokens_user_id",
            //    table: "tokens",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "users_email_unique",
            //    table: "users",
            //    column: "email",
            //    unique: true,
            //    filter: "([email] IS NOT NULL)");

            //migrationBuilder.CreateIndex(
            //    name: "users_username_unique",
            //    table: "users",
            //    column: "username",
            //    unique: true,
            //    filter: "([username] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admAcoes");

            migrationBuilder.DropTable(
                name: "admArea");

            migrationBuilder.DropTable(
                name: "admUsuario");

            migrationBuilder.DropTable(
                name: "admUsuariosAreas");

            migrationBuilder.DropTable(
                name: "adonis_schema");

            migrationBuilder.DropTable(
                name: "avise");

            migrationBuilder.DropTable(
                name: "curEmpresas");

            migrationBuilder.DropTable(
                name: "curInstrutor");

            migrationBuilder.DropTable(
                name: "curLocal");

            migrationBuilder.DropTable(
                name: "curTreinamento");

            migrationBuilder.DropTable(
                name: "curTreinamentoCategoria");

            migrationBuilder.DropTable(
                name: "curTreinamentoInteresse");

            migrationBuilder.DropTable(
                name: "curTurma");

            migrationBuilder.DropTable(
                name: "curTurmaFase");

            migrationBuilder.DropTable(
                name: "curTurmaGrupo");

            migrationBuilder.DropTable(
                name: "curUsuarios");

            migrationBuilder.DropTable(
                name: "curUsuarios_teste");

            migrationBuilder.DropTable(
                name: "curUsuariosTurmas");

            migrationBuilder.DropTable(
                name: "dtproperties");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "evento");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "lembrete");

            migrationBuilder.DropTable(
                name: "mail_controle");

            migrationBuilder.DropTable(
                name: "MailCampanhas");

            migrationBuilder.DropTable(
                name: "MailContas");

            migrationBuilder.DropTable(
                name: "MailEmails");

            migrationBuilder.DropTable(
                name: "MailGrupos");

            migrationBuilder.DropTable(
                name: "MailHistory");

            migrationBuilder.DropTable(
                name: "MailView");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Orders_teste");

            migrationBuilder.DropTable(
                name: "Ordersteste");

            migrationBuilder.DropTable(
                name: "pesq_satif_8");

            migrationBuilder.DropTable(
                name: "pesq_satisf");

            migrationBuilder.DropTable(
                name: "pesq_satisf_10");

            migrationBuilder.DropTable(
                name: "pesq_satisf_11");

            migrationBuilder.DropTable(
                name: "pesq_satisf_12");

            migrationBuilder.DropTable(
                name: "pesq_satisf_13");

            migrationBuilder.DropTable(
                name: "pesq_satisf_14");

            migrationBuilder.DropTable(
                name: "pesq_satisf_2");

            migrationBuilder.DropTable(
                name: "pesq_satisf_3");

            migrationBuilder.DropTable(
                name: "pesq_satisf_4");

            migrationBuilder.DropTable(
                name: "pesq_satisf_5");

            migrationBuilder.DropTable(
                name: "pesq_satisf_6");

            migrationBuilder.DropTable(
                name: "pesq_satisf_7");

            migrationBuilder.DropTable(
                name: "pesq_satisf_8");

            migrationBuilder.DropTable(
                name: "pesq_satisf_9");

            migrationBuilder.DropTable(
                name: "pesq_satisf_extra");

            migrationBuilder.DropTable(
                name: "SRA010");

            migrationBuilder.DropTable(
                name: "TB_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "TB_CONHECIMENTOS");

            migrationBuilder.DropTable(
                name: "TB_EMPRESAS_PRODUTOS");

            migrationBuilder.DropTable(
                name: "TB_EMPRESASNova");

            migrationBuilder.DropTable(
                name: "tb_enquete");

            migrationBuilder.DropTable(
                name: "TB_TRANSFERENCIA_ARQUIVOS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS_LOG");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS_PRODUTOS");

            migrationBuilder.DropTable(
                name: "TbArquivos");

            migrationBuilder.DropTable(
                name: "tbCasosSucesso");

            migrationBuilder.DropTable(
                name: "TbCategoria");

            migrationBuilder.DropTable(
                name: "tbContatos");

            migrationBuilder.DropTable(
                name: "tbEmpresa_Produtos");

            migrationBuilder.DropTable(
                name: "tbEmpresa_Usuarios");

            migrationBuilder.DropTable(
                name: "TbEmpresa_Usuarios_Pastas");

            migrationBuilder.DropTable(
                name: "tbEmpresa_Usuarios_Produtos");

            migrationBuilder.DropTable(
                name: "tbEmpresas");

            migrationBuilder.DropTable(
                name: "tbEmpresasPastas");

            migrationBuilder.DropTable(
                name: "tbEmpresasPastasArquivos");

            migrationBuilder.DropTable(
                name: "tbEnqueteVotado");

            migrationBuilder.DropTable(
                name: "tbFaqInfo");

            migrationBuilder.DropTable(
                name: "tbFaqTipo");

            migrationBuilder.DropTable(
                name: "tbGerCliSub");

            migrationBuilder.DropTable(
                name: "tbGerenciador");

            migrationBuilder.DropTable(
                name: "tbGerenciadorCli");

            migrationBuilder.DropTable(
                name: "tbGerenciadorUsu");

            migrationBuilder.DropTable(
                name: "TbNoticias");

            migrationBuilder.DropTable(
                name: "TbNoticiasCategorias");

            migrationBuilder.DropTable(
                name: "tbPesquicaC");

            migrationBuilder.DropTable(
                name: "tbPesquisaComent");

            migrationBuilder.DropTable(
                name: "tbPesquisaP");

            migrationBuilder.DropTable(
                name: "tbPesquisaQ");

            migrationBuilder.DropTable(
                name: "tbPesquisaTipo");

            migrationBuilder.DropTable(
                name: "tbPesquisaTitulo");

            migrationBuilder.DropTable(
                name: "tbProdutos");

            migrationBuilder.DropTable(
                name: "tbProdutosCategorias");

            migrationBuilder.DropTable(
                name: "tbProdutosCategoriasArquivos");

            migrationBuilder.DropTable(
                name: "TbProdutosPastas");

            migrationBuilder.DropTable(
                name: "tbsolucao");

            migrationBuilder.DropTable(
                name: "tbUpload");

            migrationBuilder.DropTable(
                name: "tbUsuarios");

            migrationBuilder.DropTable(
                name: "tokens");

            migrationBuilder.DropTable(
                name: "UserDefault");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VwArquivos");

            migrationBuilder.DropTable(
                name: "VwProdutos");

            migrationBuilder.DropTable(
                name: "properties");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropTable(
                name: "TB_PRODUTOS");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "TB_EMPRESAS");
        }
    }
}
