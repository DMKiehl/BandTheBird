using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "AlphaCode", "BandSize", "MaxCulmen", "MaxTail", "MaxWing", "MinCulmen", "MinTail", "MinWing", "SpeciesName" },
                values: new object[,]
                {
                    { 1, "RWBL", "F-1A/M-2", 16.5, 105.0, 135.0, 15.300000000000001, 64.0, 88.0, "Red-winged Blackbird" },
                    { 28, "EAPH", "0-1", 14.0, 78.0, 91.0, 13.0, 63.0, 76.0, "Eastern Phoebe" },
                    { 29, "NOCA", "1A", 18.699999999999999, 127.0, 105.0, 15.300000000000001, 86.0, 82.0, "Northern Cardinal" },
                    { 30, "AMRE", "0A-0", 11.0, 58.0, 69.0, 7.0, 52.0, 55.0, "American Redstart" },
                    { 31, "AMRO", "2", 23.0, 112.0, 145.0, 20.0, 85.0, 115.0, "American Robin" },
                    { 32, "YBSA", "1B-1A", 25.199999999999999, 77.0, 130.0, 19.300000000000001, 62.0, 110.0, "Yellow-bellied Sapsucker" },
                    { 33, "PISI", "0", 9.8000000000000007, 50.0, 77.0, 8.0999999999999996, 40.0, 66.0, "Pine Siskin" },
                    { 34, "ATSP", "0", 11.1, 74.0, 82.0, 7.7999999999999998, 60.0, 67.0, "American Tree Sparrow" },
                    { 35, "LISP", "0", 11.0, 61.0, 69.0, 7.0, 48.0, 54.0, "Lincoln Sparrow" },
                    { 36, "SOSP", "1B", 12.6, 74.0, 72.0, 10.300000000000001, 62.0, 59.0, "Song Sparrow" },
                    { 37, "SWSP", "1", 11.0, 64.0, 65.0, 7.0, 51.0, 52.0, "Swamp Sparrow" },
                    { 38, "TRES", "1", 7.0, 57.0, 125.0, 6.0, 49.0, 98.0, "Tree Swallow" },
                    { 39, "SCTA", "1B", 10.4, 72.0, 101.0, 9.9000000000000004, 62.0, 86.0, "Scarlet Tanager" },
                    { 40, "BRTH", "2-3", 28.800000000000001, 141.0, 117.0, 22.100000000000001, 111.0, 94.0, "Brown Thrasher" },
                    { 41, "HETH", "1B", 15.199999999999999, 79.0, 110.0, 13.0, 58.0, 78.0, "Hermit Thrush" },
                    { 42, "SWTH", "1B", 9.5, 78.0, 104.0, 8.0, 61.0, 87.0, "Swainson's Thrush" },
                    { 43, "TUTI", "1B", 13.0, 79.0, 86.0, 11.0, 64.0, 73.0, "Tufted Titmouse" },
                    { 44, "EATO", "F-1A-2/M-2-1A", 16.199999999999999, 101.0, 94.0, 12.9, 79.0, 72.0, "Eastern Towhee" },
                    { 45, "VEER", "1B", 14.6, 79.0, 106.0, 12.4, 62.0, 89.0, "Veery" },
                    { 46, "REVI", "1", 13.6, 60.0, 85.0, 11.6, 47.0, 72.0, "Red-eyed Vireo" },
                    { 47, "COYE", "0-0A", 15.0, 58.0, 58.0, 13.0, 43.0, 47.0, "Common Yellowthroat" },
                    { 48, "YWAR", "0-0A", 7.9000000000000004, 50.0, 68.0, 6.9000000000000004, 38.0, 55.0, "Yellow Warbler" },
                    { 27, "HAWO", "1A-2", 33.5, 90.0, 138.0, 24.600000000000001, 59.0, 107.0, "Hairy Woodpecker" },
                    { 26, "OVEN", "1-0", 13.9, 57.0, 81.0, 13.0, 48.0, 67.0, "Ovenbird" },
                    { 25, "DOWO", "1B", 18.800000000000001, 72.0, 115.0, 15.4, 48.0, 84.0, "Downy Woodpecker" },
                    { 24, "BAOR", "1A", 18.899999999999999, 78.0, 100.0, 15.800000000000001, 64.0, 83.0, "Baltimore Oriole" },
                    { 2, "EABL", "1B-1", 11.0, 70.0, 109.0, 7.0, 57.0, 91.0, "Eastern Bluebird" },
                    { 3, "GRCA", "1A", 17.800000000000001, 104.0, 99.0, 13.300000000000001, 81.0, 81.0, "Gray Catbird" },
                    { 4, "BCCH", "0", 10.5, 72.0, 73.0, 7.5999999999999996, 53.0, 57.0, "Black-capped Chickadee" },
                    { 5, "BHCO", "F-1B/M-1A", 16.0, 79.0, 104.0, 12.699999999999999, 57.0, 85.0, "Brown-headed Cowbird" },
                    { 6, "BBCU", "2", 23.899999999999999, 167.0, 147.0, 20.199999999999999, 146.0, 137.0, "Black-billed Cuckoo" },
                    { 7, "BRCR", "0A-0", 22.100000000000001, 69.0, 69.0, 16.899999999999999, 53.0, 57.0, "Brown Creeper" },
                    { 8, "MYWA", "0", 10.300000000000001, 60.0, 78.0, 8.4000000000000004, 53.0, 65.0, "Myrtle Warbler" },
                    { 9, "MODO", "3A-3B", 22.5, 163.0, 159.0, 18.0, 114.0, 131.0, "Mourning Dove" },
                    { 10, "HOFI", "1B-1", 12.0, 66.0, 83.0, 9.5, 51.0, 70.0, "House Finch" },
                    { 11, "PUFI", "1-1B", 12.0, 87.0, 87.0, 9.5, 53.0, 71.0, "Purple Finch" },
                    { 49, "YPWA", "0-0A", 11.5, 59.0, 71.0, 10.5, 51.0, 61.0, "Palm Warbler" },
                    { 12, "CSWA", "0A-0", 9.9000000000000004, 52.0, 68.0, 9.4000000000000004, 42.0, 56.0, "Chestnut-sided Warbler" },
                    { 14, "AMGO", "0", 10.199999999999999, 52.0, 79.0, 8.9000000000000004, 39.0, 63.0, "American Goldfinch" },
                    { 15, "COGR", "3-3B", 24.0, 148.0, 150.0, 23.0, 97.0, 115.0, "Common Grackle" },
                    { 16, "RBGR", "1A-2", 18.199999999999999, 79.0, 110.0, 15.4, 66.0, 90.0, "Rose-breasted Grosbeak" },
                    { 17, "BLJA", "2", 25.399999999999999, 148.0, 148.0, 23.899999999999999, 106.0, 115.0, "Blue Jay" },
                    { 18, "DEJU", "0-1", 14.9, 74.0, 83.0, 13.9, 62.0, 72.0, "Dark-eyed Junco" },
                    { 19, "EAKI", "1B", 15.0, 91.0, 128.0, 13.9, 74.0, 106.0, "Eastern Kingbird" },
                    { 20, "RCKI", "0A", 7.5, 51.0, 63.0, 6.0, 38.0, 50.0, "Ruby-crowned Kinglet" },
                    { 21, "GCKI", "0A", 7.5, 47.0, 62.0, 6.25, 37.0, 49.0, "Golden-crowned Kinglet" },
                    { 22, "RBNU", "0", 14.1, 39.0, 73.0, 13.5, 33.0, 60.0, "Red-breasted Nuthatch" },
                    { 23, "WBNU", "1B", 23.0, 52.0, 96.0, 16.0, 39.0, 80.0, "White-breasted Nuthatch" },
                    { 13, "BGGN", "0A", 11.199999999999999, 55.0, 56.0, 8.8000000000000007, 47.0, 46.0, "Blue-Gray Gnatcatcher" },
                    { 50, "CEDW", "1B", 8.0, 61.0, 100.0, 5.0, 50.0, 88.0, "Cedar Waxwing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "SpeciesId",
                keyValue: 50);
        }
    }
}
