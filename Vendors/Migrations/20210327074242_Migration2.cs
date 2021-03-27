using Microsoft.EntityFrameworkCore.Migrations;

namespace vendors.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpperatingHours",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TakeoutOrCurbside",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpperatingHours",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "TakeoutOrCurbside",
                table: "Vendors");
        }
    }
}
