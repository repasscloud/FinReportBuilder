using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinReportBuilder.Migrations
{
    /// <inheritdoc />
    public partial class InitialCrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialReportYearEnds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirmName = table.Column<string>(type: "TEXT", nullable: false),
                    FirmPartnerName = table.Column<string>(type: "TEXT", nullable: false),
                    FirmAddress = table.Column<string>(type: "TEXT", nullable: false),
                    ReportGeneratedDate = table.Column<string>(type: "TEXT", nullable: false),
                    YearEndedStatement = table.Column<string>(type: "TEXT", nullable: false),
                    ClientName = table.Column<string>(type: "TEXT", nullable: false),
                    DirectorsName = table.Column<string>(type: "TEXT", nullable: false),
                    HasABN = table.Column<bool>(type: "INTEGER", nullable: false),
                    ABN = table.Column<string>(type: "TEXT", nullable: false),
                    BasisOfReport = table.Column<string>(type: "TEXT", nullable: false),
                    HasPropertyPlantEquipment = table.Column<bool>(type: "INTEGER", nullable: false),
                    PropertyPlantEquipment = table.Column<string>(type: "TEXT", nullable: false),
                    PropertyPlantEquipmentDepreciation = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialReportYearEnds", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialReportYearEnds");
        }
    }
}
