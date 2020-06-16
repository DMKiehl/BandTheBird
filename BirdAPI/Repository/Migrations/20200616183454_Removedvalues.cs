using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Removedvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxBillToTip",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "MinBillToTip",
                table: "Species");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MaxBillToTip",
                table: "Species",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinBillToTip",
                table: "Species",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
