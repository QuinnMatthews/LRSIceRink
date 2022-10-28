using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Data.Migrations
{
    public partial class AddSkateUsage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkatesUsage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SkateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkatesUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkatesUsage_Skates_SkateId",
                        column: x => x.SkateId,
                        principalTable: "Skates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkatesUsage_SkateId",
                table: "SkatesUsage",
                column: "SkateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkatesUsage");
        }
    }
}
