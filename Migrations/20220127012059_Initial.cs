using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Bill Condon", false, "", "", "PG-13", "Twilight: Breaking Dawn Part 1", "2011" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Bill Condon", false, "", "", "PG-13", "Twilight: Breaking Dawn Part 2", "2012" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Tom McGrath", false, "", "", "PG", "Megamind", "2010" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
