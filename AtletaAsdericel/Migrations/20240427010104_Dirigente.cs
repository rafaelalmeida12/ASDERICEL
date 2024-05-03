using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class Dirigente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pai = table.Column<string>(type: "text", nullable: false),
                    Mae = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    Apelido = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: true),
                    DataExpedicao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TipoDocumento = table.Column<string>(type: "text", nullable: true),
                    Passaporte = table.Column<string>(type: "text", nullable: false),
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
                    EscolaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atleta_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atleta_Escolas_EscolaId",
                        column: x => x.EscolaId,
                        principalTable: "Escolas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dirigente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pai = table.Column<string>(type: "text", nullable: false),
                    Mae = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: true),
                    Apelido = table.Column<string>(type: "text", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Sexo = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    RG = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: true),
                    DataExpedicao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TipoDocumento = table.Column<string>(type: "text", nullable: true),
                    Passaporte = table.Column<string>(type: "text", nullable: false),
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
                    CREF = table.Column<string>(type: "text", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dirigente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dirigente_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dirigente_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_EnderecoId",
                table: "Atleta",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_EscolaId",
                table: "Atleta",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dirigente_EnderecoId",
                table: "Dirigente",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dirigente_ModalidadeId",
                table: "Dirigente",
                column: "ModalidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Dirigente");
        }
    }
}
