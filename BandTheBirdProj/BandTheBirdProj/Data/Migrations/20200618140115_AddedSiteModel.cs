using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class AddedSiteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a113d71f-ce87-484c-bf15-203d4922db81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2a5af6d-290f-4ba8-b0f1-8a7d6a275313");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Environmental");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Environmental");

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Environmental",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SiteName",
                table: "Environmental",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "BandingData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SiteName",
                table: "BandingData",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ResearchSite",
                columns: table => new
                {
                    SiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(nullable: true),
                    SiteStreetAddress = table.Column<string>(nullable: true),
                    SiteCity = table.Column<string>(nullable: true),
                    SiteState = table.Column<string>(nullable: true),
                    SiteZip = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchSite", x => x.SiteId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c87b7dc-7227-428c-b5d6-45e09a72b2f6", "48a64f15-f45b-4371-88bd-181c92a6ec4f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73d3ea15-74ad-4f05-a526-104303efd162", "906450c6-c3d7-498c-b112-0216ca8f756f", "Researcher", "RESEARCHER" });

            migrationBuilder.CreateIndex(
                name: "IX_Environmental_SiteId",
                table: "Environmental",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_BandingData_SiteId",
                table: "BandingData",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_BandingData_ResearchSite_SiteId",
                table: "BandingData",
                column: "SiteId",
                principalTable: "ResearchSite",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Environmental_ResearchSite_SiteId",
                table: "Environmental",
                column: "SiteId",
                principalTable: "ResearchSite",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BandingData_ResearchSite_SiteId",
                table: "BandingData");

            migrationBuilder.DropForeignKey(
                name: "FK_Environmental_ResearchSite_SiteId",
                table: "Environmental");

            migrationBuilder.DropTable(
                name: "ResearchSite");

            migrationBuilder.DropIndex(
                name: "IX_Environmental_SiteId",
                table: "Environmental");

            migrationBuilder.DropIndex(
                name: "IX_BandingData_SiteId",
                table: "BandingData");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c87b7dc-7227-428c-b5d6-45e09a72b2f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73d3ea15-74ad-4f05-a526-104303efd162");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Environmental");

            migrationBuilder.DropColumn(
                name: "SiteName",
                table: "Environmental");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "BandingData");

            migrationBuilder.DropColumn(
                name: "SiteName",
                table: "BandingData");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Environmental",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Environmental",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a113d71f-ce87-484c-bf15-203d4922db81", "f6bdc3c3-f9e2-41ec-8096-953913800542", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2a5af6d-290f-4ba8-b0f1-8a7d6a275313", "d1c5af02-9f02-4ba3-8feb-13a8f08f0f17", "Researcher", "RESEARCHER" });
        }
    }
}
