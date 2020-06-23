using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class updatedValueInResearcher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c55ff620-6141-49ed-bfbd-f1026b86a66f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d872c70c-6fee-43e1-a773-8a85aea140e8");

            migrationBuilder.AlterColumn<string>(
                name: "ResearchSiteZip",
                table: "Researcher",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f48b1c27-cfa7-478e-80d9-90179096cfc2", "7ce53455-1b6b-4dcd-ae34-8d1b265787d4", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65dad199-3582-44e8-9559-ad3b8c42ef46", "b09bb408-3f56-45ec-93f3-cbc62a457a79", "Researcher", "Researcher" });

            migrationBuilder.InsertData(
                table: "BandSize",
                columns: new[] { "Id", "Size" },
                values: new object[] { 8, "R" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65dad199-3582-44e8-9559-ad3b8c42ef46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f48b1c27-cfa7-478e-80d9-90179096cfc2");

            migrationBuilder.DeleteData(
                table: "BandSize",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "ResearchSiteZip",
                table: "Researcher",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c55ff620-6141-49ed-bfbd-f1026b86a66f", "e67b971f-05ec-4d10-8c5d-ec343be1a8fb", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d872c70c-6fee-43e1-a773-8a85aea140e8", "ce550e70-a7e9-45df-b903-0142caa39b4b", "Researcher", "Researcher" });
        }
    }
}
