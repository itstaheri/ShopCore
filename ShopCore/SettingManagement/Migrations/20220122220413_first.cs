using Microsoft.EntityFrameworkCore.Migrations;

namespace SettingManagement.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "setting",
                columns: table => new
                {
                    ContectNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContectEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderRight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderLeft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContectUs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContectUsAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "setting");
        }
    }
}
