using Microsoft.EntityFrameworkCore.Migrations;

namespace RSWEBProekt_v1.Migrations
{
    public partial class nextLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fullPath",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullPath",
                table: "Images");
        }
    }
}
