using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class atualizarAssociado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Calca",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Camisa",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Associado");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "Associado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Altura",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Calca",
                table: "Associado",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Camisa",
                table: "Associado",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoDocumento",
                table: "Associado",
                type: "text",
                nullable: true);
        }
    }
}
