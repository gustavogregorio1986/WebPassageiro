using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPassageiro.Data.Migrations
{
    public partial class AdicionarCampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MStatus",
                table: "Passageiros",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "MStatus",
                table: "Avioes",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Passageiros",
                newName: "MStatus");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Avioes",
                newName: "MStatus");
        }
    }
}
