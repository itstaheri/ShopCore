using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class OrderModelStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "OrderDetailModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderDetailModel");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
