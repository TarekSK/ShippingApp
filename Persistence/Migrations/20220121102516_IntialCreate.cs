using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Couriers",
                columns: table => new
                {
                    CourierId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourierName = table.Column<string>(type: "TEXT", nullable: true),
                    ParcelWeightKgMin = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelWeightKgMax = table.Column<decimal>(type: "TEXT", nullable: false),
                    PacelDimensionCmMin = table.Column<decimal>(type: "TEXT", nullable: false),
                    PacelDimensionCmMax = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couriers", x => x.CourierId);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PackageWidth = table.Column<decimal>(type: "TEXT", nullable: false),
                    PackageHeight = table.Column<decimal>(type: "TEXT", nullable: false),
                    PackageDepth = table.Column<decimal>(type: "TEXT", nullable: false),
                    PackageWeight = table.Column<decimal>(type: "TEXT", nullable: false),
                    CourierId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Packages_Couriers_CourierId",
                        column: x => x.CourierId,
                        principalTable: "Couriers",
                        principalColumn: "CourierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelDimensionsPricing",
                columns: table => new
                {
                    ParcelDimensionsPricingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ParcelDimensionsCmFrom = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelDimensionsCmTo = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelDimensionsPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CourierId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelDimensionsPricing", x => x.ParcelDimensionsPricingId);
                    table.ForeignKey(
                        name: "FK_ParcelDimensionsPricing_Couriers_CourierId",
                        column: x => x.CourierId,
                        principalTable: "Couriers",
                        principalColumn: "CourierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcelWeightPricing",
                columns: table => new
                {
                    ParcelWeightPricingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ParcelWeightKgFrom = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelWeightKgTo = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelWeightPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelWeightIsAddKgPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ParcelKgPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CourierId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcelWeightPricing", x => x.ParcelWeightPricingId);
                    table.ForeignKey(
                        name: "FK_ParcelWeightPricing_Couriers_CourierId",
                        column: x => x.CourierId,
                        principalTable: "Couriers",
                        principalColumn: "CourierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_CourierId",
                table: "Packages",
                column: "CourierId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelDimensionsPricing_CourierId",
                table: "ParcelDimensionsPricing",
                column: "CourierId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcelWeightPricing_CourierId",
                table: "ParcelWeightPricing",
                column: "CourierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "ParcelDimensionsPricing");

            migrationBuilder.DropTable(
                name: "ParcelWeightPricing");

            migrationBuilder.DropTable(
                name: "Couriers");
        }
    }
}
