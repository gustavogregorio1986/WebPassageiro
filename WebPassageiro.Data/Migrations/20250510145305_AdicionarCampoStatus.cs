using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPassageiro.Data.Migrations
{
    public partial class AdicionarCampoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MStatus",
                table: "Passageiros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MStatus",
                table: "Avioes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MStatus",
                table: "Passageiros");

            migrationBuilder.DropColumn(
                name: "MStatus",
                table: "Avioes");
        }
    }
}
