using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class CorrecaoFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Membros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Efetividade",
                table: "Membros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 7, 1, 1, 7, 27, 980, DateTimeKind.Utc).AddTicks(9030) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Membros",
                keyColumn: "Foto",
                keyValue: null,
                column: "Foto",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Membros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Membros",
                keyColumn: "Efetividade",
                keyValue: null,
                column: "Efetividade",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Efetividade",
                table: "Membros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360), new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360), new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360), new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360), new DateTime(2022, 6, 30, 19, 52, 48, 774, DateTimeKind.Utc).AddTicks(4360) });
        }
    }
}
