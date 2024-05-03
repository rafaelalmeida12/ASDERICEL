using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class evento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "Promocao",
                table: "Evento",
                newName: "Promotor");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Evento",
                newName: "Local");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Promotor",
                table: "Evento",
                newName: "Promocao");

            migrationBuilder.RenameColumn(
                name: "Local",
                table: "Evento",
                newName: "Pais");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Evento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Evento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Evento",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
