using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj22.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d798fdf-b9bf-498f-b21c-8427d9411e79", "AQAAAAEAACcQAAAAEMbKBi9VFlKlRMBFA2gfEMQfpgqD0lHCwYcD8ABkSpZsPxk+46bb3uzdEl9Nk5Qt8w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74da88e0-0074-4e89-b6e4-0e74d622b794", "AQAAAAEAACcQAAAAEL+R39Vils26yY368+4GZY+2AKPLsHJeJvnh7FdzC8UmXmzheZ7yTW33wpjRwgRp2g==" });
        }
    }
}
