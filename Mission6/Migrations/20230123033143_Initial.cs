using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addMovies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addMovies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Tony Scott", false, null, null, "PG", "Top Gun", "1986" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Comedy", "David Mickey Evans", false, null, null, "PG", "The Sandlot", "1993" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Television", "Various", false, null, null, "PG", "The Office", "2005-2013" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 4, "Comedy", "Dennis Dugan", false, null, null, "PG-13", "Grown Ups", "2010" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 5, "Action/Adventure", "Sam Raimi", false, null, null, "PG-13", "Spider-Man", "2002" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addMovies");
        }
    }
}
