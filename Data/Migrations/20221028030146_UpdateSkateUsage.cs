using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Data.Migrations
{
    public partial class UpdateSkateUsage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkatesUsage_Skates_SkateId",
                table: "SkatesUsage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeIn",
                table: "SkatesUsage",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "SkateId",
                table: "SkatesUsage",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_SkatesUsage_Skates_SkateId",
                table: "SkatesUsage",
                column: "SkateId",
                principalTable: "Skates",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkatesUsage_Skates_SkateId",
                table: "SkatesUsage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeIn",
                table: "SkatesUsage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SkateId",
                table: "SkatesUsage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SkatesUsage_Skates_SkateId",
                table: "SkatesUsage",
                column: "SkateId",
                principalTable: "Skates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
