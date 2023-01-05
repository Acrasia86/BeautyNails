using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class newSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a15e38c-2425-40e5-b184-5789d0e031c9", "AQAAAAEAACcQAAAAEMv39IYfmiKehKOYfg8SH4W8rN8wF/wThWCPCGrEdZlouUoKOm023bdhXGiPxp3TOw==", "85674d1a-62b3-47ae-a0ea-dfb240464a2e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "Blabla", "db0f6fd9-5e09-4480-83e4-6407952471e6", "Los", "Aleksandra@mail.com", true, false, null, "ALEKSANDRA@MAIL.COM", "ALEKSANDRA@MAIL.COM", "AQAAAAEAACcQAAAAEN6W6VVS8SBc3LpqBcJ/YNnpAF5GUEMsOxjhKPn2t3N1+w4rHUJoKh+JTojTiUqPjA==", null, false, "86326a29-6689-4376-b776-19805f223b94", false, "Aleksandra@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a1b13e7-e417-485b-a4a7-d2bf8c1b6482", "AQAAAAEAACcQAAAAEJVEoKY2uoRBjDkoL/kJASjTrlzXpoA426wzPZSzRqnBrJXvZs9r37C6xJkbwCuDIg==", "997ffeca-d053-42a5-abb8-33615e30cb5b" });
        }
    }
}
