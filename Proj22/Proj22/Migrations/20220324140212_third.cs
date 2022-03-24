using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj22.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74da88e0-0074-4e89-b6e4-0e74d622b794", "AQAAAAEAACcQAAAAEL+R39Vils26yY368+4GZY+2AKPLsHJeJvnh7FdzC8UmXmzheZ7yTW33wpjRwgRp2g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ada46982-875c-426a-8836-f7473646c2fe", "AQAAAAEAACcQAAAAEOtqI4rBcGLyzWfle1Y1k8HJcTeaGLE7xaFzYHLzdHbLceTmi4QmGY2KgeQbYNWY5w==" });
        }
    }
}
