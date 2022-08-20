using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_DOTNET6.Migrations
{
    public partial class SeedExaminePersonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExaminePerson",
                columns: new[] { "Id", "ContactDetails", "Feedback", "Name", "Oraganization" },
                values: new object[] { 1, "32568.1254.3325", "UX Part of app is good.", "Rahul Sharma", "ABC University" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExaminePerson",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
