using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class modalidadeid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Modalidades_ModalidadeId",
                table: "Atletas");

            migrationBuilder.DropIndex(
                name: "IX_Atletas_ModalidadeId",
                table: "Atletas");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Atletas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Atletas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Atletas_ModalidadeId",
                table: "Atletas",
                column: "ModalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Modalidades_ModalidadeId",
                table: "Atletas",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
