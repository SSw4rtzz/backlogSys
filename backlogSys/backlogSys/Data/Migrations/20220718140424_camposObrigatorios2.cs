using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class camposObrigatorios2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "db46c377-c2de-4d6d-b007-5dfd3458308b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "a1f63713-51aa-44da-b12f-4ff18deb79cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f",
                column: "ConcurrencyStamp",
                value: "4d7394e7-4f66-476d-a411-e88d179a7ce5");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310), new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310), new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310), new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310), new DateTime(2022, 7, 18, 14, 4, 24, 515, DateTimeKind.Utc).AddTicks(2310) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
