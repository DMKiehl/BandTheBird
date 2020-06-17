using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class addedValuesToEnvironmental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5308a86-1c2f-4e4b-8a4e-c8188e579a0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f880cbd1-b1e8-42fb-ba91-61325dd1bc49");

            migrationBuilder.CreateTable(
                name: "BandingData",
                columns: table => new
                {
                    BirdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandNumber = table.Column<double>(nullable: false),
                    CaptureDate = table.Column<DateTime>(nullable: true),
                    BanderIntials = table.Column<string>(nullable: true),
                    CaptureTime = table.Column<string>(nullable: true),
                    NetNumber = table.Column<int>(nullable: false),
                    BandType = table.Column<string>(nullable: true),
                    BandSize = table.Column<string>(nullable: true),
                    AlphaCode = table.Column<string>(nullable: true),
                    SpeciesName = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandingData", x => x.BirdId);
                    table.ForeignKey(
                        name: "FK_BandingData_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Environmental",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResearchDate = table.Column<DateTime>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    OpenTemp = table.Column<double>(nullable: false),
                    CloseTemp = table.Column<double>(nullable: false),
                    CloudCover = table.Column<string>(nullable: true),
                    Precipitation = table.Column<string>(nullable: true),
                    OpenTime = table.Column<string>(nullable: true),
                    CloseTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environmental", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Researcher",
                columns: table => new
                {
                    ResearchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ResearchSiteAddress = table.Column<string>(nullable: true),
                    ResearchSiteCity = table.Column<string>(nullable: true),
                    ResearchSiteState = table.Column<string>(nullable: true),
                    ResearchSiteZip = table.Column<int>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researcher", x => x.ResearchId);
                    table.ForeignKey(
                        name: "FK_Researcher_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BiologicalData",
                columns: table => new
                {
                    BioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    HowAged = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    HowSexed = table.Column<string>(nullable: true),
                    CloacalProtuberance = table.Column<int>(nullable: false),
                    BroodPatch = table.Column<int>(nullable: false),
                    Skull = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    BodyMolt = table.Column<int>(nullable: false),
                    FlightFeatherMolt = table.Column<string>(nullable: true),
                    FlightFeatherWear = table.Column<int>(nullable: false),
                    Mass = table.Column<double>(nullable: false),
                    WingChord = table.Column<double>(nullable: false),
                    TailLength = table.Column<double>(nullable: false),
                    ExposedCulmen = table.Column<double>(nullable: false),
                    Tarsus = table.Column<double>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    BirdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiologicalData", x => x.BioId);
                    table.ForeignKey(
                        name: "FK_BiologicalData_BandingData_BirdId",
                        column: x => x.BirdId,
                        principalTable: "BandingData",
                        principalColumn: "BirdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "261cbe27-0340-4fc2-8940-14ca3960941a", "34842bdc-1d00-4e99-a87a-c9ffba5ccac7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "762a5f60-cb37-46d6-992d-97d74a61aa35", "6aa18eb0-0d75-4003-834b-fa8967e3bb00", "Researcher", "RESEARCHER" });

            migrationBuilder.CreateIndex(
                name: "IX_BandingData_IdentityUserId",
                table: "BandingData",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BiologicalData_BirdId",
                table: "BiologicalData",
                column: "BirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Researcher_IdentityUserId",
                table: "Researcher",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiologicalData");

            migrationBuilder.DropTable(
                name: "Environmental");

            migrationBuilder.DropTable(
                name: "Researcher");

            migrationBuilder.DropTable(
                name: "BandingData");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261cbe27-0340-4fc2-8940-14ca3960941a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "762a5f60-cb37-46d6-992d-97d74a61aa35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5308a86-1c2f-4e4b-8a4e-c8188e579a0e", "11a9b9a5-2a92-41f6-87e3-d30a69ba3182", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f880cbd1-b1e8-42fb-ba91-61325dd1bc49", "56d9120c-6fe6-47a4-ad61-88922b641853", "Researcher", "RESEARCHER" });
        }
    }
}
