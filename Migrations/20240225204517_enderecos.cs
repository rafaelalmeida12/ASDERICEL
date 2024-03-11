using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class enderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Endereco_EnderecoId",
                table: "Responsavel");

            migrationBuilder.DropIndex(
                name: "IX_Responsavel_EnderecoId",
                table: "Responsavel");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Responsavel");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria",
                table: "Modalidades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Atletas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Atletas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_ResponsavelId",
                table: "Atletas",
                column: "ResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Responsavel_ResponsavelId",
                table: "Atletas",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Responsavel_ResponsavelId",
                table: "Atletas");

            migrationBuilder.DropIndex(
                name: "IX_Atletas_ResponsavelId",
                table: "Atletas");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Atletas");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Responsavel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Modalidades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Atletas",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Responsavel_EnderecoId",
                table: "Responsavel",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Endereco_EnderecoId",
                table: "Responsavel",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
