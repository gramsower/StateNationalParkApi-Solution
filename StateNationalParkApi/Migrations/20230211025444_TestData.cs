using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StateNationalParkApi.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkName", "ParkState", "StateOrNational" },
                values: new object[] { 1, "Crater Lake", "Oregon", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkName", "ParkState", "StateOrNational" },
                values: new object[] { 2, "Yosemite", "California", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkName", "ParkState", "StateOrNational" },
                values: new object[] { 3, "Champoeg", "Oregon", "State" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);
        }
    }
}
