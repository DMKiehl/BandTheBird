using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class AddedResearcherModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "170af9fb-8f5d-42d3-88a6-c85a652d6641");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f02504-70eb-4e3d-a2de-280b387d1553");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5308a86-1c2f-4e4b-8a4e-c8188e579a0e", "11a9b9a5-2a92-41f6-87e3-d30a69ba3182", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f880cbd1-b1e8-42fb-ba91-61325dd1bc49", "56d9120c-6fe6-47a4-ad61-88922b641853", "Researcher", "RESEARCHER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5308a86-1c2f-4e4b-8a4e-c8188e579a0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f880cbd1-b1e8-42fb-ba91-61325dd1bc49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "170af9fb-8f5d-42d3-88a6-c85a652d6641", "fb61f9a1-d442-4ed4-8ef1-05a5c33fb594", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4f02504-70eb-4e3d-a2de-280b387d1553", "8c3ddce7-8d32-4473-9a90-dfd08d1e2f31", "Researcher", "RESEARCHER" });
        }
    }
}
