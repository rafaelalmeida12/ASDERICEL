using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class tbl_categoriaModalidade_sexoModalidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sexo_Modalidades_ModalidadeId",
                table: "Sexo");

            migrationBuilder.DropTable(
                name: "CategoriaModalidade");

            migrationBuilder.DropIndex(
                name: "IX_Sexo_ModalidadeId",
                table: "Sexo");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Sexo");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeSexos",
                columns: table => new
                {
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false),
                    SexoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeSexos", x => new { x.ModalidadeId, x.SexoId });
                    table.ForeignKey(
                        name: "FK_ModalidadeSexos_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModalidadeSexos_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadeCategorias",
                columns: table => new
                {
                    ModalidadeId = table.Column<int>(type: "integer", nullable: false),
                    CategoriaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadeCategorias", x => new { x.ModalidadeId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_ModalidadeCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModalidadeCategorias_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Mirim" },
                    { 2, "Infantil" },
                    { 3, "Sub13Misto" },
                    { 4, "Sub15" },
                    { 5, "Sub17" },
                    { 6, "Sub20" },
                    { 7, "Adulto" }
                });

            migrationBuilder.InsertData(
                table: "Sexo",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Feminino" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeCategorias_CategoriaId",
                table: "ModalidadeCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModalidadeSexos_SexoId",
                table: "ModalidadeSexos",
                column: "SexoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModalidadeCategorias");

            migrationBuilder.DropTable(
                name: "ModalidadeSexos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DeleteData(
                table: "Sexo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sexo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Sexo",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriaModalidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModalidadeId = table.Column<int>(type: "integer", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Sexo_ModalidadeId",
                table: "Sexo",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaModalidade_ModalidadeId",
                table: "CategoriaModalidade",
                column: "ModalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sexo_Modalidades_ModalidadeId",
                table: "Sexo",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id");
        }
    }
}
