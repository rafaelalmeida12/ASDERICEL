using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class ALTERACOES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataExpedicaoRG",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "NivelEnsino",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "PaisPassaporte",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "PassaporteNumero",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "PassaporteTipo",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "TamanhoCalca",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "TamanhoCamisa",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Associado");

            migrationBuilder.RenameColumn(
                name: "Profissao",
                table: "Responsavel",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "OrgaoEmissor",
                table: "Responsavel",
                newName: "Parentesco");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Associado",
                newName: "TipoDocumento");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Responsavel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TipoSanguineo",
                table: "Associado",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpedicao",
                table: "Associado",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OrgaoEmissor",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Passaporte",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "DataExpedicao",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "OrgaoEmissor",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Passaporte",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Associado");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Responsavel",
                newName: "Profissao");

            migrationBuilder.RenameColumn(
                name: "Parentesco",
                table: "Responsavel",
                newName: "OrgaoEmissor");

            migrationBuilder.RenameColumn(
                name: "TipoDocumento",
                table: "Associado",
                newName: "Codigo");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpedicaoRG",
                table: "Responsavel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelEnsino",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TipoSanguineo",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Altura",
                table: "Associado",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Associado",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaisPassaporte",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassaporteNumero",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassaporteTipo",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Peso",
                table: "Associado",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TamanhoCalca",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TamanhoCamisa",
                table: "Associado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Associado",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
