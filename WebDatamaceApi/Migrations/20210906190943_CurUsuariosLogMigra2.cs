using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDatamaceApi.Migrations
{
    public partial class CurUsuariosLogMigra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurUsuariosLog_curUsuarios_CurUsuariosIdUsuario",
                table: "CurUsuariosLog");

            migrationBuilder.AlterColumn<int>(
                name: "CurUsuariosIdUsuario",
                table: "CurUsuariosLog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CurUsuariosLog_curUsuarios_CurUsuariosIdUsuario",
                table: "CurUsuariosLog",
                column: "CurUsuariosIdUsuario",
                principalTable: "curUsuarios",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
