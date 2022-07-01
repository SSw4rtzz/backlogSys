using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class CorrecaodeErroFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1780), new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1770), new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1780), new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1780), new DateTime(2022, 6, 30, 19, 44, 27, 955, DateTimeKind.Utc).AddTicks(1780) });
        }
    }
}
