using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlphaCode = table.Column<string>(nullable: true),
                    BandSize = table.Column<string>(nullable: true),
                    MinWing = table.Column<double>(nullable: false),
                    MaxWing = table.Column<double>(nullable: false),
                    MinTail = table.Column<double>(nullable: false),
                    MaxTail = table.Column<double>(nullable: false),
                    MinCulmen = table.Column<double>(nullable: false),
                    MaxCulmen = table.Column<double>(nullable: false),
                    MinBillToTip = table.Column<double>(nullable: false),
                    MaxBillToTip = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
