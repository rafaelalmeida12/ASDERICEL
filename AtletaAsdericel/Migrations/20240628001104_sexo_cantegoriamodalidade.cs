using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class sexo_cantegoriamodalidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atleta_Endereco_EnderecoId",
                table: "Atleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Atleta_Escolas_EscolaId",
                table: "Atleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Atleta_Modalidades_ModalidadeId",
                table: "Atleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Dirigente_Endereco_EnderecoId",
                table: "Dirigente");

            migrationBuilder.DropForeignKey(
                name: "FK_Dirigente_Modalidades_ModalidadeId",
                table: "Dirigente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dirigente",
                table: "Dirigente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atleta",
                table: "Atleta");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Modalidades");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Modalidades");

            migrationBuilder.RenameTable(
                name: "Dirigente",
                newName: "Dirigentes");

            migrationBuilder.RenameTable(
                name: "Atleta",
                newName: "Atletas");

            migrationBuilder.RenameIndex(
                name: "IX_Dirigente_ModalidadeId",
                table: "Dirigentes",
                newName: "IX_Dirigentes_ModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dirigente_EnderecoId",
                table: "Dirigentes",
                newName: "IX_Dirigentes_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Atleta_ModalidadeId",
                table: "Atletas",
                newName: "IX_Atletas_ModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Atleta_EscolaId",
                table: "Atletas",
                newName: "IX_Atletas_EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Atleta_EnderecoId",
                table: "Atletas",
                newName: "IX_Atletas_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dirigentes",
                table: "Dirigentes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atletas",
                table: "Atletas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoriaModalidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaModalidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaModalidade_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sexo_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaModalidade_ModalidadeId",
                table: "CategoriaModalidade",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sexo_ModalidadeId",
                table: "Sexo",
                column: "ModalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Endereco_EnderecoId",
                table: "Atletas",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Escolas_EscolaId",
                table: "Atletas",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atletas_Modalidades_ModalidadeId",
                table: "Atletas",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dirigentes_Endereco_EnderecoId",
                table: "Dirigentes",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dirigentes_Modalidades_ModalidadeId",
                table: "Dirigentes",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Endereco_EnderecoId",
                table: "Atletas");

            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Escolas_EscolaId",
                table: "Atletas");

            migrationBuilder.DropForeignKey(
                name: "FK_Atletas_Modalidades_ModalidadeId",
                table: "Atletas");

            migrationBuilder.DropForeignKey(
                name: "FK_Dirigentes_Endereco_EnderecoId",
                table: "Dirigentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dirigentes_Modalidades_ModalidadeId",
                table: "Dirigentes");

            migrationBuilder.DropTable(
                name: "CategoriaModalidade");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dirigentes",
                table: "Dirigentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atletas",
                table: "Atletas");

            migrationBuilder.RenameTable(
                name: "Dirigentes",
                newName: "Dirigente");

            migrationBuilder.RenameTable(
                name: "Atletas",
                newName: "Atleta");

            migrationBuilder.RenameIndex(
                name: "IX_Dirigentes_ModalidadeId",
                table: "Dirigente",
                newName: "IX_Dirigente_ModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dirigentes_EnderecoId",
                table: "Dirigente",
                newName: "IX_Dirigente_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_ModalidadeId",
                table: "Atleta",
                newName: "IX_Atleta_ModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_EscolaId",
                table: "Atleta",
                newName: "IX_Atleta_EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Atletas_EnderecoId",
                table: "Atleta",
                newName: "IX_Atleta_EnderecoId");

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Modalidades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Modalidades",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dirigente",
                table: "Dirigente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atleta",
                table: "Atleta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atleta_Endereco_EnderecoId",
                table: "Atleta",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atleta_Escolas_EscolaId",
                table: "Atleta",
                column: "EscolaId",
                principalTable: "Escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atleta_Modalidades_ModalidadeId",
                table: "Atleta",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dirigente_Endereco_EnderecoId",
                table: "Dirigente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dirigente_Modalidades_ModalidadeId",
                table: "Dirigente",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
