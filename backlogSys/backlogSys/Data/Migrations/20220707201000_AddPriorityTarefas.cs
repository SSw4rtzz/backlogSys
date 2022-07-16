using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class AddPriorityTarefas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prioridade",
                table: "Tarefas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Tarefas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "34639e08-a408-4a37-891c-94694a13807d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c",
                column: "ConcurrencyStamp",
                value: "3cb49f25-1a48-46fa-afbe-525f5de78d56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f",
                column: "ConcurrencyStamp",
                value: "ee11eedf-fcc5-4759-9571-5b570d20a243");

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 7, 2, 16, 12, 46, 532, DateTimeKind.Utc).AddTicks(2080) });
        }
    }
}
