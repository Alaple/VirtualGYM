using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualGYM.Migrations
{
    public partial class BaseDeDatosCotexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objetivos_Socios_SociosId",
                table: "Objetivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Empresas_EmpresaId",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Objetivos_SociosId",
                table: "Objetivos");

            migrationBuilder.DropColumn(
                name: "SociosId",
                table: "Objetivos");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Socios",
                newName: "IdObjetivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_EmpresaId",
                table: "Socios",
                newName: "IX_Socios_IdObjetivoId");

            migrationBuilder.AlterColumn<double>(
                name: "Peso",
                table: "Socios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Socios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Altura",
                table: "Socios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresaId",
                table: "Socios",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Completada",
                table: "Rutinas_Objetivos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Completada",
                table: "Clases_Objetivos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Socios_IdEmpresaId",
                table: "Socios",
                column: "IdEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Empresas_IdEmpresaId",
                table: "Socios",
                column: "IdEmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Objetivos_IdObjetivoId",
                table: "Socios",
                column: "IdObjetivoId",
                principalTable: "Objetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Empresas_IdEmpresaId",
                table: "Socios");

            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Objetivos_IdObjetivoId",
                table: "Socios");

            migrationBuilder.DropIndex(
                name: "IX_Socios_IdEmpresaId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "IdEmpresaId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "Completada",
                table: "Rutinas_Objetivos");

            migrationBuilder.DropColumn(
                name: "Completada",
                table: "Clases_Objetivos");

            migrationBuilder.RenameColumn(
                name: "IdObjetivoId",
                table: "Socios",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_IdObjetivoId",
                table: "Socios",
                newName: "IX_Socios_EmpresaId");

            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Edad",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Altura",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "SociosId",
                table: "Objetivos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Objetivos_SociosId",
                table: "Objetivos",
                column: "SociosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objetivos_Socios_SociosId",
                table: "Objetivos",
                column: "SociosId",
                principalTable: "Socios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Empresas_EmpresaId",
                table: "Socios",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
