using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCade.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserAccountName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserAccountName);
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserAccountName", "Name", "Password" },
                values: new object[] { "FuckMeInAss", "Greg", "1234" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserAccountName", "Name", "Password" },
                values: new object[] { "Mini-carrot cake", "Carrot Cake", "899" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserAccountName", "Name", "Password" },
                values: new object[] { "ThatAss", "Cake", "L0L" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserAccountName", "Name", "Password" },
                values: new object[] { "AssIsBest", "Bob", "911" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
