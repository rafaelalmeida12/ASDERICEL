using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class tabela_associado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Endereco_EnderecoId",
                table: "Atletas");

            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Equipe_EquipeId",
                table: "Atletas");

            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Responsavel_ResponsavelId",
                table: "Atletas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atletas",
                table: "Atletas");

            migrationBuilder.RenameTable(
                name: "Atletas",
                newName: "Associado");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_ResponsavelId",
                table: "Associado",
                newName: "IX_Associado_ResponsavelId");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_EquipeId",
                table: "Associado",
                newName: "IX_Associado_EquipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_EnderecoId",
                table: "Associado",
                newName: "IX_Associado_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Associado",
                table: "Associado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Associado_Endereco_EnderecoId",
                table: "Associado",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associado_Equipe_EquipeId",
                table: "Associado",
                column: "EquipeId",
                principalTable: "Equipe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Associado_Responsavel_ResponsavelId",
                table: "Associado",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associado_Endereco_EnderecoId",
                table: "Associado");

            migrationBuilder.DropForeignKey(
                name: "FK_Associado_Equipe_EquipeId",
                table: "Associado");

            migrationBuilder.DropForeignKey(
                name: "FK_Associado_Responsavel_ResponsavelId",
                table: "Associado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Associado",
                table: "Associado");

            migrationBuilder.RenameTable(
                name: "Associado",
                newName: "Atletas");

            migrationBuilder.RenameIndex(
                name: "IX_Associado_ResponsavelId",
                table: "Atletas",
                newName: "IX_Atletas_ResponsavelId");

            migrationBuilder.RenameIndex(
                name: "IX_Associado_EquipeId",
                table: "Atletas",
                newName: "IX_Atletas_EquipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Associado_EnderecoId",
                table: "Atletas",
                newName: "IX_Atletas_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atletas",
                table: "Atletas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Endereco_EnderecoId",
                table: "Atletas",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Equipe_EquipeId",
                table: "Atletas",
                column: "EquipeId",
                principalTable: "Equipe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Responsavel_ResponsavelId",
                table: "Atletas",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
