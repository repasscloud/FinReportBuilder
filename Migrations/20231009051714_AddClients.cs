using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinReportBuilder.Migrations
{
    /// <inheritdoc />
    public partial class AddClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessName = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessStructure = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessRegistrationDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PreferredCommunicationMethod = table.Column<string>(type: "TEXT", nullable: true),
                    SundayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    MondayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    TuesdayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    WednesdayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    ThursdayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    FridayAppointments = table.Column<string>(type: "TEXT", nullable: true),
                    SaturdayAppointments = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address1 = table.Column<string>(type: "TEXT", nullable: true),
                    Address2 = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    PostCode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    MailingAddress1 = table.Column<string>(type: "TEXT", nullable: true),
                    MailingAddress2 = table.Column<string>(type: "TEXT", nullable: true),
                    MailingCity = table.Column<string>(type: "TEXT", nullable: true),
                    MailingState = table.Column<string>(type: "TEXT", nullable: true),
                    MailingPostCode = table.Column<string>(type: "TEXT", nullable: true),
                    MailingCountry = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PreferredContactMethod = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParagraphFormattingInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BackColor = table.Column<string>(type: "TEXT", nullable: false),
                    LeftIndentation = table.Column<int>(type: "INTEGER", nullable: false),
                    RightIndentation = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstLineIndentation = table.Column<int>(type: "INTEGER", nullable: false),
                    Keep = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParagraphFormattingInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextFormattingInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FontName = table.Column<string>(type: "TEXT", nullable: false),
                    FontSize = table.Column<float>(type: "REAL", nullable: false),
                    Bold = table.Column<bool>(type: "INTEGER", nullable: false),
                    Italic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Underline = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFormattingInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerOf = table.Column<string>(type: "TEXT", nullable: false),
                    EntityName = table.Column<string>(type: "TEXT", nullable: false),
                    ContactInformationId = table.Column<int>(type: "INTEGER", nullable: true),
                    TaxFileNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ABN = table.Column<string>(type: "TEXT", nullable: true),
                    ACN = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessInformationId = table.Column<int>(type: "INTEGER", nullable: true),
                    PreferencesId = table.Column<int>(type: "INTEGER", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientProfiles_BusinessInfo_BusinessInformationId",
                        column: x => x.BusinessInformationId,
                        principalTable: "BusinessInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientProfiles_ClientPreferences_PreferencesId",
                        column: x => x.PreferencesId,
                        principalTable: "ClientPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClientProfiles_ContactInfo_ContactInformationId",
                        column: x => x.ContactInformationId,
                        principalTable: "ContactInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentManagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityOwner = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentType = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentName = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentPath = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentData = table.Column<byte[]>(type: "BLOB", nullable: true),
                    ClientProfileId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentManagement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentManagement_ClientProfiles_ClientProfileId",
                        column: x => x.ClientProfileId,
                        principalTable: "ClientProfiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProfiles_BusinessInformationId",
                table: "ClientProfiles",
                column: "BusinessInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProfiles_ContactInformationId",
                table: "ClientProfiles",
                column: "ContactInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProfiles_PreferencesId",
                table: "ClientProfiles",
                column: "PreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentManagement_ClientProfileId",
                table: "DocumentManagement",
                column: "ClientProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentManagement");

            migrationBuilder.DropTable(
                name: "ParagraphFormattingInfos");

            migrationBuilder.DropTable(
                name: "TextFormattingInfos");

            migrationBuilder.DropTable(
                name: "ClientProfiles");

            migrationBuilder.DropTable(
                name: "BusinessInfo");

            migrationBuilder.DropTable(
                name: "ClientPreferences");

            migrationBuilder.DropTable(
                name: "ContactInfo");
        }
    }
}
