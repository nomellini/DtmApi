using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDatamaceApi.Migrations
{
    public partial class CurUsuariosLogMigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurUsuariosLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurUsuariosIdUsuario = table.Column<int>(nullable: true),
                    DataLog = table.Column<DateTime>(nullable: false),
                    Log = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurUsuariosLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurUsuariosLog_curUsuarios_CurUsuariosIdUsuario",
                        column: x => x.CurUsuariosIdUsuario,
                        principalTable: "curUsuarios",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurUsuariosLog_CurUsuariosIdUsuario",
                table: "CurUsuariosLog",
                column: "CurUsuariosIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurUsuariosLog");
        }
    }
}
