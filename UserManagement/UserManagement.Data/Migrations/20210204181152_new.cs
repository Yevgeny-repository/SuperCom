using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace UserManagement.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneSkype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "FirstName", "ImageData", "LastName", "PhoneSkype", "TimeZone", "WebSite" },
                values: new object[] { new Guid("3fdc65ee-a96f-458f-bfc4-9cb4be0d8e78"), "Hi", "Test", null, "User", "None", "Europe/Warsaw", "http://microsoft.net" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "FirstName", "ImageData", "LastName", "PhoneSkype", "TimeZone", "WebSite" },
                values: new object[] { new Guid("e6552edd-9a1f-428f-b4a3-fdee7f55df0f"), "Hi Second", "Test", null, "Second User", "None", "Europe/Israel", "http://microsoft.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}