using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entertainers",
                columns: table => new
                {
                    EntertainerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntStageName = table.Column<string>(nullable: false),
                    EntSSN = table.Column<string>(nullable: true),
                    EntStreetAddress = table.Column<string>(nullable: true),
                    EntCity = table.Column<string>(nullable: true),
                    EntState = table.Column<string>(nullable: true),
                    EntZipCode = table.Column<string>(nullable: true),
                    EntPhoneNumber = table.Column<string>(nullable: true),
                    EntWebPage = table.Column<string>(nullable: true),
                    EntEMailAddress = table.Column<string>(nullable: true),
                    DateEntered = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entertainers", x => x.EntertainerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entertainers");
        }
    }
}
