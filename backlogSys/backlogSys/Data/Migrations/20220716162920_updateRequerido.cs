using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class updateRequerido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "940026b5-0a71-41e2-90ac-e7f3c6f51116");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "7047b50d-b219-4ed4-8887-b76bb06de46b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f",
                column: "ConcurrencyStamp",
                value: "5025e023-ccdf-48b1-9e06-31d38f7831fc");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960), new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960), new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960), new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960), new DateTime(2022, 7, 7, 20, 9, 59, 939, DateTimeKind.Utc).AddTicks(6960) });
        }
    }
}
