using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class Added3Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de915059-fa9a-4ac0-ab70-61ddfd29f722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc941e31-e31e-4a54-9d99-c2674fd2dfc6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "170af9fb-8f5d-42d3-88a6-c85a652d6641", "fb61f9a1-d442-4ed4-8ef1-05a5c33fb594", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4f02504-70eb-4e3d-a2de-280b387d1553", "8c3ddce7-8d32-4473-9a90-dfd08d1e2f31", "Researcher", "RESEARCHER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "fc941e31-e31e-4a54-9d99-c2674fd2dfc6", "226cf7d1-a21f-4773-8adf-77f4335f56f6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de915059-fa9a-4ac0-ab70-61ddfd29f722", "895f04f3-db34-42c1-b1e4-d8c67f00c9d2", "Researcher", "RESEARCHER" });
        }
    }
}
