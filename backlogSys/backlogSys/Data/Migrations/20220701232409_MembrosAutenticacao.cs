using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class MembrosAutenticacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Membros",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Membros",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRegisto",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a", "bc69ed7d-05cf-4c73-bffb-7e41f864dc8b", "Administrativo", "ADMINISTRATIVO" },
                    { "c", "275756b4-0d2a-4249-ba37-28449649b00f", "Chefe", "CHEFE" },
                    { "f", "15086eb9-3fad-406b-b926-0c77c175ae05", "Funcionario", "FUNCIONARIO" }
                });

            migrationBuilder.InsertData(
                table: "Membros",
                columns: new[] { "Id", "Efetividade", "Email", "EquipaFK", "Foto", "Nome", "UserId" },
                values: new object[] { 11, "Sim", "mferreira@empresa.com", 4, "null.png", "Marina Ferreira", null });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2380), new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2380), new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2390), new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2380), new DateTime(2022, 7, 1, 23, 24, 9, 531, DateTimeKind.Utc).AddTicks(2390) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f");

            migrationBuilder.DeleteData(
                table: "Membros",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "DataRegisto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Membros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
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
    }
}
