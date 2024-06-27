using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    /// <inheritdoc />
    public partial class passaporteisNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataTermino",
                table: "Evento",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Evento",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataNascimento",
            //    table: "Dirigente",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp without time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataExpedicao",
            //    table: "Dirigente",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp without time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataNascimento",
            //    table: "Atleta",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp without time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataExpedicao",
            //    table: "Atleta",
            //    type: "timestamp with time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Passaporte",
                table: "Associado",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Associado",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpedicao",
                table: "Associado",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataTermino",
                table: "Evento",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicio",
                table: "Evento",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataNascimento",
            //    table: "Dirigente",
            //    type: "timestamp without time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataExpedicao",
            //    table: "Dirigente",
            //    type: "timestamp without time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataNascimento",
            //    table: "Atleta",
            //    type: "timestamp without time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

            //migrationBuilder.AlterColumn<DateTime>(
            //    name: "DataExpedicao",
            //    table: "Atleta",
            //    type: "timestamp without time zone",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Passaporte",
                table: "Associado",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Associado",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpedicao",
                table: "Associado",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
