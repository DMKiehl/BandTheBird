using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class Added2Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e0024f4-68d1-44b8-9cf8-77dacef034b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f97bf084-bf6b-49b3-80f8-8d612bf0742c");

            migrationBuilder.CreateTable(
                name: "BandType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sex",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sex", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0710ec2b-900b-41ce-8d05-292c91b3e45c", "47d2be9d-7b91-49b0-86bf-9a0525890c52", "Admin", "Admin" },
                    { "c852bee5-db91-403a-85bd-3d1aba587364", "a34f31eb-6f58-42ca-88cb-55fbfe7318ef", "Researcher", "Researcher" }
                });

            migrationBuilder.InsertData(
                table: "BandType",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "N", "New Band" },
                    { 2, "D", "Band Destroyed" },
                    { 3, "L", "Band Lost" },
                    { 4, "C", "Band Changed" },
                    { 5, "A", "Band Added" },
                    { 6, "R", "Recapture" }
                });

            migrationBuilder.InsertData(
                table: "Sex",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "M", "Male" },
                    { 2, "F", "Female" },
                    { 3, "U", "Undetermined" },
                    { 4, "X", "Not Attempted" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BandType");

            migrationBuilder.DropTable(
                name: "Sex");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0710ec2b-900b-41ce-8d05-292c91b3e45c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c852bee5-db91-403a-85bd-3d1aba587364");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e0024f4-68d1-44b8-9cf8-77dacef034b3", "efe2b051-0d61-4a7a-a3fd-bf21e95f9b57", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f97bf084-bf6b-49b3-80f8-8d612bf0742c", "b7acd610-60f7-488b-a2a2-9593ca99f30c", "Researcher", "Researcher" });
        }
    }
}
