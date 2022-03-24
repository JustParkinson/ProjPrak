using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj22.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BrithDay", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { 1, 0, new DateTime(1999, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ada46982-875c-426a-8836-f7473646c2fe", "xd@xd.pl", true, "Łuaksz", "Nowak", false, null, "xd@xd.pl", null, "AQAAAAEAACcQAAAAEOtqI4rBcGLyzWfle1Y1k8HJcTeaGLE7xaFzYHLzdHbLceTmi4QmGY2KgeQbYNWY5w==", null, false, null, false, "Admin", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
