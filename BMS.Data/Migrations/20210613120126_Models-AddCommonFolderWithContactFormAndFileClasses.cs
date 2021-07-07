using Microsoft.EntityFrameworkCore.Migrations;

namespace BMS.Data.Migrations
{
    public partial class ModelsAddCommonFolderWithContactFormAndFileClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingAccounts_PaymentTypes_PaymentTypeId",
                table: "BuildingAccounts");

            migrationBuilder.DropIndex(
                name: "IX_BuildingAccounts_PaymentTypeId",
                table: "BuildingAccounts");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "BuildingAccounts");

            migrationBuilder.AddColumn<string>(
                name: "TransactionsType",
                table: "OutgoingPayments",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionsType",
                table: "OutgoingPayments");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "BuildingAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingAccounts_PaymentTypeId",
                table: "BuildingAccounts",
                column: "PaymentTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingAccounts_PaymentTypes_PaymentTypeId",
                table: "BuildingAccounts",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
