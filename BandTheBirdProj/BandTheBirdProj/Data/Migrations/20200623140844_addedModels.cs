using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class addedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c10009cc-a961-4350-ad93-19c95b54b590");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daed91a2-3ebc-42fa-9226-75973fbe9a6e");

            migrationBuilder.CreateTable(
                name: "BandSize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyMolt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMolt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightMolt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightMolt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightWear",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightWear", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d872c70c-6fee-43e1-a773-8a85aea140e8", "ce550e70-a7e9-45df-b903-0142caa39b4b", "Researcher", "Researcher" },
                    { "c55ff620-6141-49ed-bfbd-f1026b86a66f", "e67b971f-05ec-4d10-8c5d-ec343be1a8fb", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "BP",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 6, 5, "Molting" },
                    { 5, 4, "Wrinkled" },
                    { 1, 0, "None" },
                    { 3, 2, "Vascular" },
                    { 4, 3, "Heavy" },
                    { 2, 1, "Smooth" }
                });

            migrationBuilder.InsertData(
                table: "BandSize",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "0A" },
                    { 2, "0" },
                    { 3, "1" },
                    { 4, "1B" },
                    { 5, "1A" },
                    { 6, "2" },
                    { 7, "3" }
                });

            migrationBuilder.InsertData(
                table: "BodyMolt",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 0, "None" },
                    { 2, 1, "Trace" },
                    { 3, 2, "Light" },
                    { 4, 3, "Medium" },
                    { 5, 4, "Heavy" }
                });

            migrationBuilder.InsertData(
                table: "CP",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "None" },
                    { 3, "Large" },
                    { 1, "Small" },
                    { 2, "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Fat",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 0, "None" },
                    { 8, 7, "Very Excessive" },
                    { 7, 6, "Gr. Bulging" },
                    { 2, 1, "Trace" },
                    { 5, 4, "Filled" },
                    { 4, 3, "Half" },
                    { 3, 2, "Light" },
                    { 6, 5, "Bulging" }
                });

            migrationBuilder.InsertData(
                table: "FlightMolt",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "N", "None" },
                    { 3, "S", "Symmetric" },
                    { 4, "J", "Juvenile Growth" },
                    { 2, "A", "Adventitious" }
                });

            migrationBuilder.InsertData(
                table: "FlightWear",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, 0, "None" },
                    { 2, 1, "Slight" },
                    { 3, 2, "Light" },
                    { 4, 3, "Moderate" },
                    { 5, 4, "Heavy" },
                    { 6, 5, "Excessive" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BandSize");

            migrationBuilder.DropTable(
                name: "BodyMolt");

            migrationBuilder.DropTable(
                name: "BP");

            migrationBuilder.DropTable(
                name: "CP");

            migrationBuilder.DropTable(
                name: "Fat");

            migrationBuilder.DropTable(
                name: "FlightMolt");

            migrationBuilder.DropTable(
                name: "FlightWear");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c55ff620-6141-49ed-bfbd-f1026b86a66f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d872c70c-6fee-43e1-a773-8a85aea140e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c10009cc-a961-4350-ad93-19c95b54b590", "99af7a57-7ad4-4254-a22b-5376f143e814", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daed91a2-3ebc-42fa-9226-75973fbe9a6e", "1d2cfd85-8f6d-4df6-b1c0-c4945ff23e0f", "Researcher", "Researcher" });
        }
    }
}
