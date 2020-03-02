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
                    Name = table.Column<string>(nullable: false),
                    UserAccountName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Name", "Password", "UserAccountName" },
                values: new object[] { "Greg", "1234", "FuckMeInAss" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Name", "Password", "UserAccountName" },
                values: new object[] { "Carrot Cake", "899", "Mini-carrot cake" });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Name", "Password", "UserAccountName" },
                values: new object[] { "Cake", "L0L", "ThatAss" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
