using Microsoft.EntityFrameworkCore.Migrations;

namespace Smtih_Midterm.Migrations
{
    public partial class initalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoFilter = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pic1 = table.Column<string>(nullable: true),
                    Pic2 = table.Column<string>(nullable: true),
                    Pic3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoFilter);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    HouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(nullable: false),
                    PhotoFilter = table.Column<int>(nullable: false),
                    PhotosPhotoFilter = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    BedRCount = table.Column<int>(nullable: false),
                    SqFt = table.Column<int>(nullable: false),
                    BathCount = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CodeOut = table.Column<string>(nullable: true),
                    Heating = table.Column<string>(nullable: true),
                    AC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.HouseId);
                    table.ForeignKey(
                        name: "FK_Infos_Photos_PhotosPhotoFilter",
                        column: x => x.PhotosPhotoFilter,
                        principalTable: "Photos",
                        principalColumn: "PhotoFilter",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Infos_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoFilter", "Pic1", "Pic2", "Pic3" },
                values: new object[,]
                {
                    { 1, "bathroom1.jpg", "bedroom1.jpg", "kitchen1.jpg" },
                    { 2, "bathroom2.jpg", "bedroom2.jpg", "kitchen2.jpg" },
                    { 3, "bathroom3.jpg", "bedroom3.jpg", "kitchen3.jpg" },
                    { 4, "bathroom4.jpg", "bedroom4.jpg", "kitchen4.jpg" },
                    { 5, "bathroom5.jpg", "bedroom5.jpg", "kitchen5.jpg" },
                    { 6, "bathroom6.jpg", "bedroom6.jpg", "kitchen6.jpg" },
                    { 7, "bathroom7.jpg", "bedroom7.jpg", "kitchen7.jpg" },
                    { 8, "bathroom8.jpg", "bedroom8.jpg", "kitchen8.jpg" },
                    { 9, "bathroom9.jpg", "bedroom9.jpg", "kitchen9.jpg" },
                    { 10, "bathroom10.jpg", "bedroom10.jpg", "kitchen10.jpg" },
                    { 11, "bathroom11.jpg", "bedroom11.jpg", "kitchen11.jpg" },
                    { 12, "bathroom12.jpg", "bedroom12.jpg", "kitchen12.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { 1, "Richmond" },
                    { 2, "Columbia" },
                    { 3, "Coffee" }
                });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "HouseId", "AC", "Address", "BathCount", "BedRCount", "CodeOut", "Heating", "PhotoFilter", "PhotosPhotoFilter", "Price", "RegionId", "SqFt", "Year" },
                values: new object[,]
                {
                    { 1, "Central", "4340 Peach Orchard Rd, Hephzibah, GA 30815", 3, 7, "out1.jpg", "Forced air, Heat pump", 1, null, 325000, 1, 5726, 1929 },
                    { 6, "Central", "213 Gardners Mill Rd, Augusta, GA", 2, 4, "out6.jpg", "Forced air", 6, null, 210000, 1, 2256, 1972 },
                    { 7, "No Data", "3335 Wedgewood Dr, Augusta, GA ", 2, 3, "out7.jpg", "Forced air", 7, null, 149900, 1, 1452, 1956 },
                    { 8, "Central", "4221 Rose Hill Dr, Hephzibah, GA ", 2, 3, "out8.jpg", "Forced air", 8, null, 124900, 1, 1415, 1989 },
                    { 2, "Central", "1105 Fawn Forest Rd, Grovetown, GA", 3, 5, "out2.jpg", "Heat pump", 2, null, 300000, 2, 3371, 2018 },
                    { 3, "No Data", "740 Meadow Hill Dr, Grovetown, GA", 2, 3, "out3.jpg", "Heat pump", 3, null, 250000, 2, 1800, 2018 },
                    { 4, "Central", "325 Crown Heights Way, Grovetown, GA", 2, 4, "out4.jpg", "Heat pump", 4, null, 204900, 2, 1691, 2015 },
                    { 5, "No Data", "535 Oak Brook Dr, Martinez, GA", 3, 4, "out5.jpg", "Forced air", 5, null, 239900, 2, 2106, 1993 },
                    { 9, "Central", "1220 Green Hollow Run, Douglas, GA", 3, 4, "out9.jpg", "Heat Pump", 9, null, 249900, 3, 2441, 1989 },
                    { 10, "Central", "215 Gaskin Ave N, Douglas, GA", 3, 4, "out10.jpg", "Other", 10, null, 229000, 3, 3662, 1898 },
                    { 11, "Central", "1807 Robin Ln, Douglas, GA", 5, 4, "out11.jpg", "Heat Pump, Other", 11, null, 224000, 3, 34046, 1992 },
                    { 12, "Central", "445 Westwood Heights Cir, Douglas, GA", 4, 5, "out12.jpg", "Heat Pump, Other", 12, null, 350000, 3, 3846, 1989 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Infos_PhotosPhotoFilter",
                table: "Infos",
                column: "PhotosPhotoFilter");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_RegionId",
                table: "Infos",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
