using Microsoft.EntityFrameworkCore.Migrations;

namespace MIssion6DevonWolsleger.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CatagoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatagoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CatagoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CatagoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Responses_Catagories_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagories",
                        principalColumn: "CatagoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "CatagoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "CatagoryName" },
                values: new object[] { 2, "Adventure" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "CatagoryName" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "CatagoryName" },
                values: new object[] { 4, "Thriller" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "CatagoryName" },
                values: new object[] { 5, "Horror" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CatagoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Quinten Tarentino", false, null, null, "R", "Kill Bill", 2003 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CatagoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 1, "George Lucas", false, null, null, "PG", "Star Wars Episode I: The Phantom Menace", 1999 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "CatagoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 2, "Larry Morey", false, null, null, "G", "Snow White and the Seven Dwarfs", 1938 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CatagoryId",
                table: "Responses",
                column: "CatagoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
