using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Migrations
{
    public partial class AddSkateArchiveStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Skates",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Skates");
        }
    }
}
