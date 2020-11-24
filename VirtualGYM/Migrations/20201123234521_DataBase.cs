using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualGYM.Migrations
{
    public partial class DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Objetivos_IdObjetivoId",
                table: "Socios");

            migrationBuilder.RenameColumn(
                name: "IdObjetivoId",
                table: "Socios",
                newName: "objetivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_IdObjetivoId",
                table: "Socios",
                newName: "IX_Socios_objetivoId");

            migrationBuilder.AddColumn<int>(
                name: "IdObjetivo",
                table: "Socios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Objetivos_objetivoId",
                table: "Socios",
                column: "objetivoId",
                principalTable: "Objetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Objetivos_objetivoId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "IdObjetivo",
                table: "Socios");

            migrationBuilder.RenameColumn(
                name: "objetivoId",
                table: "Socios",
                newName: "IdObjetivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_objetivoId",
                table: "Socios",
                newName: "IX_Socios_IdObjetivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Objetivos_IdObjetivoId",
                table: "Socios",
                column: "IdObjetivoId",
                principalTable: "Objetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
