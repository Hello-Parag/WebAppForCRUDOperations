using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_DOTNET6.Migrations
{
    public partial class AlterExaminePersonSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExaminePerson",
                columns: new[] { "Id", "ContactDetails", "Feedback", "Name", "Oraganization" },
                values: new object[] { 2, "235657.2365.3258", "Works well with CRUD Operations.", "Vivek Lambha", "XYZ Solutions" });

            migrationBuilder.InsertData(
                table: "ExaminePerson",
                columns: new[] { "Id", "ContactDetails", "Feedback", "Name", "Oraganization" },
                values: new object[] { 3, "32546.4569.2245", "This Web App Works Good.", "Ayush Srivastava", "PQR Pvt. L." });

            migrationBuilder.InsertData(
                table: "ExaminePerson",
                columns: new[] { "Id", "ContactDetails", "Feedback", "Name", "Oraganization" },
                values: new object[] { 4, "65489.2315.4658", "Love This App.", "Vijay Singh", "JIT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExaminePerson",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExaminePerson",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExaminePerson",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
