using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class AddPicturetoCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "productcategories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "productcategories");
        }
    }
}
