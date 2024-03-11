using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class escolaid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Escolas_EscolaId",
                table: "Atletas");

            migrationBuilder.DropIndex(
                name: "IX_Atletas_EscolaId",
                table: "Atletas");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "Atletas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "Atletas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_EscolaId",
                table: "Atletas",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Escolas_EscolaId",
                table: "Atletas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
