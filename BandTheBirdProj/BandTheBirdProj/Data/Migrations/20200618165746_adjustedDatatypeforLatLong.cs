using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class adjustedDatatypeforLatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c87b7dc-7227-428c-b5d6-45e09a72b2f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73d3ea15-74ad-4f05-a526-104303efd162");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "ResearchSite",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "ResearchSite",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    speciesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alphaCode = table.Column<string>(nullable: true),
                    speciesName = table.Column<string>(nullable: true),
                    bandSize = table.Column<string>(nullable: true),
                    minWing = table.Column<int>(nullable: false),
                    maxWing = table.Column<int>(nullable: false),
                    minTail = table.Column<int>(nullable: false),
                    maxTail = table.Column<int>(nullable: false),
                    minCulmen = table.Column<float>(nullable: false),
                    maxCulmen = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.speciesId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40d52b7d-0d3c-40ed-9127-eede3982cb51", "27eba148-9e0d-49f7-a16c-b9f7e941d833", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9d16ecd-3357-45b7-a1ed-584c15ac8755", "c4944c70-5308-49ef-862f-961945147169", "Researcher", "Researcher" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40d52b7d-0d3c-40ed-9127-eede3982cb51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9d16ecd-3357-45b7-a1ed-584c15ac8755");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "ResearchSite",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "ResearchSite",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c87b7dc-7227-428c-b5d6-45e09a72b2f6", "48a64f15-f45b-4371-88bd-181c92a6ec4f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73d3ea15-74ad-4f05-a526-104303efd162", "906450c6-c3d7-498c-b112-0216ca8f756f", "Researcher", "RESEARCHER" });
        }
    }
}
