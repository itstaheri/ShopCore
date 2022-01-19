using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class OrderModelPaymethod1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerDescription",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerDescription",
                table: "orders");
        }
    }
}
