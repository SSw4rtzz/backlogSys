using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class UpdateTarefas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Prazo",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Tarefas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataConclusao",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Equipa",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "DataConclusao", "DataCriacao", "Descricao", "MembrosFK", "PontoSituacao", "Prazo", "Titulo" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), "Corrigir erro do formulário das tarefas, este não está a enviar os dados para a base de dados como devia", 2, "Por fazer", new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), "Corrigir erro do formulário das tarefas, no BacklogSys" });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "DataConclusao", "DataCriacao", "Descricao", "MembrosFK", "PontoSituacao", "Prazo", "Titulo" },
                values: new object[] { 2, new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2160), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), "Criar interface para o sistema de logins", 2, "Em desenvolvimento", new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), "FrontEnd Sistema de Logins" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Prazo",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Tarefas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataConclusao",
                table: "Tarefas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Equipa",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Equipa",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
