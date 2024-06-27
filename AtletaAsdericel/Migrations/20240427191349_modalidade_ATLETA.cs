using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class modalidade_ATLETA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "ModalidadeId",
            //    table: "Atleta",
            //    type: "integer",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Atleta_ModalidadeId",
            //    table: "Atleta",
            //    column: "ModalidadeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Atleta_Modalidades_ModalidadeId",
            //    table: "Atleta",
            //    column: "ModalidadeId",
            //    principalTable: "Modalidades",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Atleta_Modalidades_ModalidadeId",
            //    table: "Atleta");

            //migrationBuilder.DropIndex(
            //    name: "IX_Atleta_ModalidadeId",
            //    table: "Atleta");

            //migrationBuilder.DropColumn(
            //    name: "ModalidadeId",
            //    table: "Atleta");
        }
    }
}
