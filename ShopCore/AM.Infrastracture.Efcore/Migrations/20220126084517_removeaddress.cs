using Microsoft.EntityFrameworkCore.Migrations;

namespace AM.Infrastracture.Efcore.Migrations
{
    public partial class removeaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accountAddress_Address",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "accountAddress_City",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "accountAddress_County",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "accountAddress_Id",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "accountAddress_PostalCode",
                table: "accounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "accountAddress_Address",
                table: "accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "accountAddress_City",
                table: "accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "accountAddress_County",
                table: "accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "accountAddress_Id",
                table: "accounts",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "accountAddress_PostalCode",
                table: "accounts",
                type: "bigint",
                nullable: true);
        }
    }
}
