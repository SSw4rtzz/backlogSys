using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backlogSys.Data.Migrations
{
    public partial class UpdateTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_Equipa_EquipaFK",
                table: "Membros");

            migrationBuilder.DropIndex(
                name: "IX_Membros_EquipaFK",
                table: "Membros");

            migrationBuilder.AddColumn<int>(
                name: "EquipaId",
                table: "Membros",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_Equipa_EquipaId",
                table: "Membros");

            migrationBuilder.DropIndex(
                name: "IX_Membros_EquipaId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "EquipaId",
                table: "Membros");

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
        }
    }
}
