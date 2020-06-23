using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class addedImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65dad199-3582-44e8-9559-ad3b8c42ef46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f48b1c27-cfa7-478e-80d9-90179096cfc2");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlphaCode = table.Column<string>(nullable: true),
                    BandNumber = table.Column<int>(nullable: false),
                    BirdImage = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e977c12-a1ee-4800-b4f3-82052f7e05bd", "663cbd32-5faf-486b-a6c3-f513f8041884", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a527b1d4-c348-442f-864f-c0fa09ff861f", "6aa9cab0-e9ab-4425-9b70-9f42a4ec13b9", "Researcher", "Researcher" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_IdentityUserId",
                table: "Images",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e977c12-a1ee-4800-b4f3-82052f7e05bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a527b1d4-c348-442f-864f-c0fa09ff861f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f48b1c27-cfa7-478e-80d9-90179096cfc2", "7ce53455-1b6b-4dcd-ae34-8d1b265787d4", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65dad199-3582-44e8-9559-ad3b8c42ef46", "b09bb408-3f56-45ec-93f3-cbc62a457a79", "Researcher", "Researcher" });
        }
    }
}
