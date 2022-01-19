using Microsoft.EntityFrameworkCore.Migrations;

namespace SM.Infrastructure.EfCore.Migrations
{
    public partial class AddUploaderToShopSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "shopSliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "shopSliders");
        }
    }
}
