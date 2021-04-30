using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace It_Takes_A_Village.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "DateAdded", "Hobby" },
                values: new object[] { new DateTime(2021, 4, 28, 14, 48, 31, 29, DateTimeKind.Local).AddTicks(8777), "Drawing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "DateAdded", "Hobby" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
