using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class Addedafewmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0710ec2b-900b-41ce-8d05-292c91b3e45c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c852bee5-db91-403a-85bd-3d1aba587364");

            migrationBuilder.CreateTable(
                name: "Age",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Age", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HowAgeSex",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HowAgeSex", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Age",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "After Hatch Year" },
                    { 2, "Hatch Year" },
                    { 4, "Local" },
                    { 5, "Second Year" },
                    { 6, "After Second Year" },
                    { 7, "Third Year" },
                    { 8, "After Third Year" },
                    { 9, "Not Attempted" },
                    { 3, "Indeterminable" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2a8e385-182c-4e47-aa4f-047360d8421d", "bd0cba80-dc75-44e0-9ec6-40c442032bc6", "Admin", "Admin" },
                    { "62357c39-c45c-41cf-87b5-8722ec8812a6", "e4a0411c-d902-4236-a0e2-d062d83de027", "Researcher", "Researcher" }
                });

            migrationBuilder.InsertData(
                table: "HowAgeSex",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "S", "Skull" },
                    { 4, "J", "Juvenile Body Plumage" },
                    { 5, "L", "Molt Limit" },
                    { 6, "P", "Plumage" },
                    { 7, "M", "Molt" },
                    { 8, "F", "Feather Wear" },
                    { 9, "I", "Mouth/Bill" },
                    { 10, "E", "Eye Color" },
                    { 11, "W", "Wing Length" },
                    { 12, "T", "Tail Length" },
                    { 13, "O", "Other(Note)" },
                    { 2, "C", "Cloacal Prot." },
                    { 3, "B", "Brood Patch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Age");

            migrationBuilder.DropTable(
                name: "HowAgeSex");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62357c39-c45c-41cf-87b5-8722ec8812a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a8e385-182c-4e47-aa4f-047360d8421d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0710ec2b-900b-41ce-8d05-292c91b3e45c", "47d2be9d-7b91-49b0-86bf-9a0525890c52", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c852bee5-db91-403a-85bd-3d1aba587364", "a34f31eb-6f58-42ca-88cb-55fbfe7318ef", "Researcher", "Researcher" });
        }
    }
}
