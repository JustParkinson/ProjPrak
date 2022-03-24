using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj22.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0295036b-a691-4ff8-b3a8-f6357f7a54d7", "Łukasz", "ADMINLN", "AQAAAAEAACcQAAAAEOGOyVRdzvi+2uzYDg7XIb90P6c/elZ1lZ5xdRSDSrK4oX6k7CuF/hbDOVMCXNPyAA==", "481768b8-bd52-4c1e-8003-7cb2b8b8a0da", "AdminLN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5d798fdf-b9bf-498f-b21c-8427d9411e79", "Łuaksz", null, "AQAAAAEAACcQAAAAEMbKBi9VFlKlRMBFA2gfEMQfpgqD0lHCwYcD8ABkSpZsPxk+46bb3uzdEl9Nk5Qt8w==", null, "Admin" });
        }
    }
}
