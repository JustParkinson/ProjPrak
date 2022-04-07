using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj22.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79e4b10d-b63e-44de-aabf-2998ac261e11", "AQAAAAEAACcQAAAAEB0E4HpI+8+STzQ+H1IvxAu9ltPIdlq/MdBIRmv0tlrCG8rTJsU3wnrI+K2VCGi+KA==", "68a19def-1a0b-4db4-8a96-e182d3ea0e81" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "This is example of an blog you can create.", "Example" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0295036b-a691-4ff8-b3a8-f6357f7a54d7", "AQAAAAEAACcQAAAAEOGOyVRdzvi+2uzYDg7XIb90P6c/elZ1lZ5xdRSDSrK4oX6k7CuF/hbDOVMCXNPyAA==", "481768b8-bd52-4c1e-8003-7cb2b8b8a0da" });
        }
    }
}
