using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Fix01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PacelDimensionCmMin",
                table: "Couriers",
                newName: "ParcelDimensionCmMin");

            migrationBuilder.RenameColumn(
                name: "PacelDimensionCmMax",
                table: "Couriers",
                newName: "ParcelDimensionCmMax");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParcelDimensionCmMin",
                table: "Couriers",
                newName: "PacelDimensionCmMin");

            migrationBuilder.RenameColumn(
                name: "ParcelDimensionCmMax",
                table: "Couriers",
                newName: "PacelDimensionCmMax");
        }
    }
}
