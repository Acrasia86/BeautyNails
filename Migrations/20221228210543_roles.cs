using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c62add6d-5df9-4ab3-8aa0-308272311f8d", "AQAAAAEAACcQAAAAEJXB+fs7qMr/EINjRORFkdDz0iIbOOWRuhBXqf6vjITxYcNzcyXe2J7W4NAhiz0OEQ==", "538d6c80-6b2f-4ccd-acf4-3fb045d3c412" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84a611e0-9f37-4bce-9a04-be5379f0374b", "AQAAAAEAACcQAAAAEIGluPEcG1nJ3D/v8qZIM1ZXtV9k6nO1qbGFmE6ueyCn8L8etZxS78/KvLIuELGueg==", "793989ad-7050-49b6-8d01-f3296a95dd66" });
        }
    }
}
