using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "addMovies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_addMovies_movieCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "movieCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "movieCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Tony Scott", false, null, null, "PG", "Top Gun", "1986" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 5, 1, "Sam Raimi", false, null, null, "PG-13", "Spider-Man", "2002" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, "David Mickey Evans", false, null, null, "PG", "The Sandlot", "1993" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 4, 2, "Dennis Dugan", false, null, null, "PG-13", "Grown Ups", "2010" });

            migrationBuilder.InsertData(
                table: "addMovies",
                columns: new[] { "Id", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 7, "Various", false, null, null, "PG", "The Office", "2005-2013" });

            migrationBuilder.CreateIndex(
                name: "IX_addMovies_CategoryID",
                table: "addMovies",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addMovies");

            migrationBuilder.DropTable(
                name: "movieCategories");
        }
    }
}
