using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class OrderModelPaymethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "orders");
        }
    }
}
