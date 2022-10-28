using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRSIceRink.Migrations
{
    public partial class AddSeedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { new Guid("262571a0-539e-4fd0-a794-4cf32e71836a"), "WarnSkateUsageMinutes", "180" });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { new Guid("603505cf-f399-4e17-84c0-b966da1af987"), "MaxSkateUsageMinutes", "240" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("262571a0-539e-4fd0-a794-4cf32e71836a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("603505cf-f399-4e17-84c0-b966da1af987"));
        }
    }
}
