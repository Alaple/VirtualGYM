using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualGYM.Migrations
{
    public partial class NewDataBaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Empresas_IdEmpresaId",
                table: "Socios");

            migrationBuilder.RenameColumn(
                name: "IdEmpresaId",
                table: "Socios",
                newName: "empresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_IdEmpresaId",
                table: "Socios",
                newName: "IX_Socios_empresaId");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Socios",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Socios",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Socios",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Socios",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Socios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Ofertas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Empresas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empresas",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Empresas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Empresas",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Empresas_empresaId",
                table: "Socios",
                column: "empresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socios_Empresas_empresaId",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Socios");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Ofertas");

            migrationBuilder.RenameColumn(
                name: "empresaId",
                table: "Socios",
                newName: "IdEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Socios_empresaId",
                table: "Socios",
                newName: "IX_Socios_IdEmpresaId");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Socios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddForeignKey(
                name: "FK_Socios_Empresas_IdEmpresaId",
                table: "Socios",
                column: "IdEmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
