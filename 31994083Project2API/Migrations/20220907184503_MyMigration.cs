using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _31994083Project2API.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<Guid>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    CategoryDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    DeviceID = table.Column<Guid>(nullable: false),
                    DeviceName = table.Column<string>(nullable: true),
                    CategoryID = table.Column<Guid>(nullable: false),
                    ZoneID = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    IsActvie = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    ZoneID = table.Column<Guid>(nullable: false),
                    ZoneName = table.Column<string>(nullable: false),
                    ZoneDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.ZoneID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Zone");
        }
    }
}
