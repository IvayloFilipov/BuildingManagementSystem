using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Data.Migrations
{
    public partial class ModelsRemoveSomeComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppartmentNumber",
                table: "Addresses",
                newName: "AppartNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppartNumber",
                table: "Addresses",
                newName: "AppartmentNumber");
        }
    }
}
