using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class product2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NetworkSupport",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingSystem",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ram",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Resolution",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ScreenSize",
                table: "products",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TouchId",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetworkSupport",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OperatingSystem",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ScreenSize",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "products");

            migrationBuilder.DropColumn(
                name: "TouchId",
                table: "products");
        }
    }
}
