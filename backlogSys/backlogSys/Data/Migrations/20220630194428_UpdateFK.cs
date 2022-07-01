using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class UpdateFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_Equipa_EquipaId",
                table: "Membros");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Membros_MembrosFK",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Membros_EquipaId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "EquipaId",
                table: "Membros");

            migrationBuilder.AlterColumn<int>(
                name: "MembrosFK",
                table: "Tarefas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Membros_EquipaFK",
                table: "Membros",
                column: "EquipaFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Membros_Equipa_EquipaFK",
                table: "Membros",
                column: "EquipaFK",
                principalTable: "Equipa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Membros_MembrosFK",
                table: "Tarefas",
                column: "MembrosFK",
                principalTable: "Membros",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_Equipa_EquipaFK",
                table: "Membros");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Membros_MembrosFK",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Membros_EquipaFK",
                table: "Membros");

            migrationBuilder.AlterColumn<int>(
                name: "MembrosFK",
                table: "Tarefas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipaId",
                table: "Membros",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataConclusao", "DataCriacao", "Prazo" },
                values: new object[] { new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2160), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150), new DateTime(2022, 6, 30, 19, 2, 5, 666, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.CreateIndex(
                name: "IX_Membros_EquipaId",
                table: "Membros",
                column: "EquipaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membros_Equipa_EquipaId",
                table: "Membros",
                column: "EquipaId",
                principalTable: "Equipa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Membros_MembrosFK",
                table: "Tarefas",
                column: "MembrosFK",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
