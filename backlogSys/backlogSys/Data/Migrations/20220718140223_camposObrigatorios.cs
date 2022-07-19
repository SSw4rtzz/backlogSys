using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class camposObrigatorios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Titulo",
                keyValue: null,
                column: "Titulo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tarefas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Equipa",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Equipa",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "cca3bb84-7584-48fc-8e9b-0ae091c843c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "287e31d4-3d13-429e-b036-e394490df60c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f",
                column: "ConcurrencyStamp",
                value: "09f600e1-d2a2-4803-be7f-6f9a931765d4");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6820), new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6810), new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6820), new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6820), new DateTime(2022, 7, 18, 14, 2, 22, 777, DateTimeKind.Utc).AddTicks(6820) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tarefas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Equipa",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "a1412160-608a-41a9-9871-a4d3eca5b617");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "c1ed04d3-cb0a-4db9-bca0-f0ed663b407b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f",
                column: "ConcurrencyStamp",
                value: "f9e70938-4b7a-4220-aac1-75221154e392");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8950), new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8940), new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8950), new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8950), new DateTime(2022, 7, 16, 16, 29, 20, 182, DateTimeKind.Utc).AddTicks(8950) });
        }
    }
}
