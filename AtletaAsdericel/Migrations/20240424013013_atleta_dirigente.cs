using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class atleta_dirigente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associado_Responsavel_ResponsavelId",
                table: "Associado");

            migrationBuilder.DropForeignKey(
                name: "FK_Prova_Modalidades_ModalidadeId",
                table: "Prova");

            migrationBuilder.DropIndex(
                name: "IX_Associado_ResponsavelId",
                table: "Associado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prova",
                table: "Prova");

            migrationBuilder.RenameTable(
                name: "Prova",
                newName: "Provas");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Endereco",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "ResponsavelId",
                table: "Associado",
                newName: "Mae");

            migrationBuilder.RenameIndex(
                name: "IX_Prova_ModalidadeId",
                table: "Provas",
                newName: "IX_Provas_ModalidadeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataTermino",
                table: "Evento",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Evento",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "INEP",
                table: "Escolas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Localidade",
                table: "Endereco",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDocumento",
                table: "Associado",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "OrgaoEmissor",
                table: "Associado",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NomeSocial",
                table: "Associado",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Associado",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpedicao",
                table: "Associado",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Associado",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Associado",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pai",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Profissao",
                table: "Associado",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoProva",
                table: "Provas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provas",
                table: "Provas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Provas_Modalidades_ModalidadeId",
                table: "Provas",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provas_Modalidades_ModalidadeId",
                table: "Provas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provas",
                table: "Provas");

            migrationBuilder.DropColumn(
                name: "INEP",
                table: "Escolas");

            migrationBuilder.DropColumn(
                name: "Localidade",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Pai",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Profissao",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "TipoProva",
                table: "Provas");

            migrationBuilder.RenameTable(
                name: "Provas",
                newName: "Prova");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Endereco",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "Mae",
                table: "Associado",
                newName: "ResponsavelId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_ModalidadeId",
                table: "Prova",
                newName: "IX_Prova_ModalidadeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataTermino",
                table: "Evento",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Evento",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "TipoDocumento",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrgaoEmissor",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeSocial",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Associado",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpedicao",
                table: "Associado",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Apelido",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prova",
                table: "Prova",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Associado_ResponsavelId",
                table: "Associado",
                column: "ResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associado_Responsavel_ResponsavelId",
                table: "Associado",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prova_Modalidades_ModalidadeId",
                table: "Prova",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
