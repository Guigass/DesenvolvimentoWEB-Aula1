using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap01.Migrations
{
    public partial class Tete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor2",
                table: "Perguntas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor2",
                table: "Perguntas",
                nullable: true);
        }
    }
}
