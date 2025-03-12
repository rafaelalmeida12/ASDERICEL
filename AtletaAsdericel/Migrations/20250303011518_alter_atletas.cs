using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class alter_atletas : Migration
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

            migrationBuilder.RenameColumn(
                name: "ModalidadeId",
                table: "Atletas",
                newName: "TipoCadastro");

            migrationBuilder.CreateTable(
                name: "AtletaFederacao",
                columns: table => new
                {
                    AtletaId = table.Column<int>(type: "int", nullable: false),
                    FederacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtletaFederacao", x => new { x.AtletaId, x.FederacaoId });
                    table.ForeignKey(
                        name: "FK_AtletaFederacao_Atletas_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atletas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtletaFederacao_Federacao_FederacaoId",
                        column: x => x.FederacaoId,
                        principalTable: "Federacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtletaModalidade",
                columns: table => new
                {
                    AtletaId = table.Column<int>(type: "int", nullable: false),
                    ModalidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtletaModalidade", x => new { x.AtletaId, x.ModalidadeId });
                    table.ForeignKey(
                        name: "FK_AtletaModalidade_Atletas_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atletas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtletaModalidade_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtletaFederacao_FederacaoId",
                table: "AtletaFederacao",
                column: "FederacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtletaModalidade_ModalidadeId",
                table: "AtletaModalidade",
                column: "ModalidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtletaFederacao");

            migrationBuilder.DropTable(
                name: "AtletaModalidade");

            migrationBuilder.RenameColumn(
                name: "TipoCadastro",
                table: "Atletas",
                newName: "ModalidadeId");

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
