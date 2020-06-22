using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class AddedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62357c39-c45c-41cf-87b5-8722ec8812a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a8e385-182c-4e47-aa4f-047360d8421d");

            migrationBuilder.CreateTable(
                name: "Skull",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skull", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c10009cc-a961-4350-ad93-19c95b54b590", "99af7a57-7ad4-4254-a22b-5376f143e814", "Admin", "Admin" },
                    { "daed91a2-3ebc-42fa-9226-75973fbe9a6e", "1d2cfd85-8f6d-4df6-b1c0-c4945ff23e0f", "Researcher", "Researcher" }
                });

            migrationBuilder.InsertData(
                table: "Skull",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "None" },
                    { 1, "Trace" },
                    { 2, "< 1/3" },
                    { 3, "Half" },
                    { 4, "> 2/3" },
                    { 5, "Almost Complete" },
                    { 6, "Fully Complete" },
                    { 8, "Invisible" },
                    { 9, "Did not Attempt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skull");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c10009cc-a961-4350-ad93-19c95b54b590");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daed91a2-3ebc-42fa-9226-75973fbe9a6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2a8e385-182c-4e47-aa4f-047360d8421d", "bd0cba80-dc75-44e0-9ec6-40c442032bc6", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62357c39-c45c-41cf-87b5-8722ec8812a6", "e4a0411c-d902-4236-a0e2-d062d83de027", "Researcher", "Researcher" });
        }
    }
}
