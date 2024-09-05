using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    Perfil = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Localidade = table.Column<string>(type: "text", nullable: false),
                    Uf = table.Column<string>(type: "text", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Escolas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    INEP = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Municipio = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Edicao = table.Column<string>(type: "text", nullable: false),
                    Promotor = table.Column<string>(type: "text", nullable: false),
                    Local = table.Column<string>(type: "text", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ModalidadePai = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Parentesco = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resultado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Gols = table.Column<int>(type: "integer", nullable: false),
                    Pontos = table.Column<int>(type: "integer", nullable: false),
                    Classificacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atletas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pai = table.Column<string>(type: "text", nullable: true),
                    Mae = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    Apelido = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: true),
                    DataExpedicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Passaporte = table.Column<string>(type: "text", nullable: true),
                    NumeroSUS = table.Column<string>(type: "text", nullable: true),
                    TipoSanguineo = table.Column<int>(type: "integer", nullable: false),
                    EstadoCivil = table.Column<int>(type: "integer", nullable: false),
                    Profissao = table.Column<string>(type: "text", nullable: true),
                    Ensino = table.Column<int>(type: "integer", nullable: false),
                    Peso = table.Column<string>(type: "text", nullable: false),
                    Altura = table.Column<string>(type: "text", nullable: false),
                    Camisa = table.Column<int>(type: "integer", nullable: false),
                    Calca = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    EscolaId = table.Column<int>(type: "integer", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atletas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atletas_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atletas_Escolas_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escolas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atletas_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dirigentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pai = table.Column<string>(type: "text", nullable: true),
                    Mae = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    Apelido = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: false),
                    DataExpedicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Profissao = table.Column<string>(type: "text", nullable: true),
                    Passaporte = table.Column<string>(type: "text", nullable: true),
                    NumeroSUS = table.Column<string>(type: "text", nullable: true),
                    CREF = table.Column<string>(type: "text", nullable: true),
                    Peso = table.Column<string>(type: "text", nullable: false),
                    Altura = table.Column<string>(type: "text", nullable: false),
                    Camisa = table.Column<int>(type: "integer", nullable: false),
                    Calca = table.Column<int>(type: "integer", nullable: false),
                    TipoSanguineo = table.Column<int>(type: "integer", nullable: false),
                    EstadoCivil = table.Column<int>(type: "integer", nullable: false),
                    Ensino = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dirigentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dirigentes_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dirigentes_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeCategorias",
                columns: table => new
                {
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false),
                    CategoriaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeCategorias", x => new { x.ModalidadeId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_ModalidadeCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModalidadeCategorias_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false),
                    TipoProva = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provas_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ResultadoId = table.Column<int>(type: "integer", nullable: false),
                    EventoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipe_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipe_Resultado_ResultadoId",
                        column: x => x.ResultadoId,
                        principalTable: "Resultado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeSexos",
                columns: table => new
                {
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false),
                    SexoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeSexos", x => new { x.ModalidadeId, x.SexoId });
                    table.ForeignKey(
                        name: "FK_ModalidadeSexos_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModalidadeSexos_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Associado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    Apelido = table.Column<string>(type: "text", nullable: true),
                    Mae = table.Column<string>(type: "text", nullable: false),
                    Pai = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: true),
                    DataExpedicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Passaporte = table.Column<string>(type: "text", nullable: true),
                    NumeroSUS = table.Column<string>(type: "text", nullable: true),
                    TipoSanguineo = table.Column<int>(type: "integer", nullable: false),
                    EstadoCivil = table.Column<int>(type: "integer", nullable: false),
                    Profissao = table.Column<string>(type: "text", nullable: true),
                    Ensino = table.Column<int>(type: "integer", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    EquipeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Associado_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Associado_Equipe_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipe",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Mirim" },
                    { 2, "Infantil" },
                    { 3, "Sub13Misto" },
                    { 4, "Sub15" },
                    { 5, "Sub17" },
                    { 6, "Sub20" },
                    { 7, "Adulto" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Porto Velho" },
                    { 2, "Ariquemes" },
                    { 3, "Guajará-Mirim" },
                    { 4, "Ariquemes" },
                    { 5, "Ji-Parana" },
                    { 6, "Rolim Moura" }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nome", "Sigla" },
                values: new object[,]
                {
                    { 1, "Acre", "AC" },
                    { 2, "Alagoas", "AL" },
                    { 3, "Amapá", "AP" },
                    { 4, "Amazonas", "AM" },
                    { 5, "Bahia", "BA" },
                    { 6, "Ceará", "CE" },
                    { 7, "Distrito Federal", "DF" },
                    { 8, "Espírito Santo", "ES" },
                    { 9, "Goiás", "GO" },
                    { 10, "Maranhão", "MA" },
                    { 11, "Mato Grosso", "MT" },
                    { 12, "Mato Grosso do Sul", "MS" },
                    { 13, "Minas Gerais", "MG" },
                    { 14, "Pará", "PA" },
                    { 15, "Paraíba", "PB" },
                    { 16, "Paraná", "PR" },
                    { 17, "Pernambuco", "PE" },
                    { 18, "Piauí", "PI" },
                    { 19, "Rio de Janeiro", "RJ" },
                    { 20, "Rio Grande do Norte", "RN" },
                    { 21, "Rio Grande do Sul", "RS" },
                    { 22, "Rondônia", "RO" },
                    { 23, "Roraima", "RR" },
                    { 24, "Santa Catarina", "SC" },
                    { 25, "São Paulo", "SP" },
                    { 26, "Sergipe", "SE" },
                    { 27, "Tocantins", "TO" }
                });

            migrationBuilder.InsertData(
                table: "Sexo",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Feminino" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associado_EnderecoId",
                table: "Associado",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Associado_EquipeId",
                table: "Associado",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_EnderecoId",
                table: "Atletas",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_EscolaId",
                table: "Atletas",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_ModalidadeId",
                table: "Atletas",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dirigentes_EnderecoId",
                table: "Dirigentes",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dirigentes_ModalidadeId",
                table: "Dirigentes",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_EventoId",
                table: "Equipe",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_ResultadoId",
                table: "Equipe",
                column: "ResultadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeCategorias_CategoriaId",
                table: "ModalidadeCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeSexos_SexoId",
                table: "ModalidadeSexos",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_ModalidadeId",
                table: "Provas",
                column: "ModalidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Associado");

            migrationBuilder.DropTable(
                name: "Atletas");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Dirigentes");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "ModalidadeCategorias");

            migrationBuilder.DropTable(
                name: "ModalidadeSexos");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Escolas");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Resultado");
        }
    }
}
