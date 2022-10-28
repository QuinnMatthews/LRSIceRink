using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Data.Migrations
{
    public partial class AddMinutesUsed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MinutesUsed",
                table: "Skates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinutesUsed",
                table: "Skates");
        }
    }
}
