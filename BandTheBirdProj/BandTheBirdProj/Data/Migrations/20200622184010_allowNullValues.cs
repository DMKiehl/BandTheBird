using Microsoft.EntityFrameworkCore.Migrations;

namespace BandTheBirdProj.Data.Migrations
{
    public partial class allowNullValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40d52b7d-0d3c-40ed-9127-eede3982cb51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9d16ecd-3357-45b7-a1ed-584c15ac8755");

            migrationBuilder.AlterColumn<double>(
                name: "Tarsus",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Skull",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FlightFeatherWear",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Fat",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CloacalProtuberance",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BroodPatch",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BodyMolt",
                table: "BiologicalData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e0024f4-68d1-44b8-9cf8-77dacef034b3", "efe2b051-0d61-4a7a-a3fd-bf21e95f9b57", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f97bf084-bf6b-49b3-80f8-8d612bf0742c", "b7acd610-60f7-488b-a2a2-9593ca99f30c", "Researcher", "Researcher" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e0024f4-68d1-44b8-9cf8-77dacef034b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f97bf084-bf6b-49b3-80f8-8d612bf0742c");

            migrationBuilder.AlterColumn<double>(
                name: "Tarsus",
                table: "BiologicalData",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Skull",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlightFeatherWear",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Fat",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CloacalProtuberance",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BroodPatch",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BodyMolt",
                table: "BiologicalData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40d52b7d-0d3c-40ed-9127-eede3982cb51", "27eba148-9e0d-49f7-a16c-b9f7e941d833", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9d16ecd-3357-45b7-a1ed-584c15ac8755", "c4944c70-5308-49ef-862f-961945147169", "Researcher", "Researcher" });
        }
    }
}
