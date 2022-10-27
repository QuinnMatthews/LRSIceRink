using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Data.Migrations
{
    public partial class AddSkateStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Skates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Skates");
        }
    }
}
