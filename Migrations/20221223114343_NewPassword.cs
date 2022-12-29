using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class NewPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "Blabla", "9ea84225-d861-4ae6-b698-f285f4c2b1d2", "Jp", "Jacob@mail.com", true, false, null, "JACOB@MAIL.COM", "JACOB@MAIL.COM", "AQAAAAEAACcQAAAAED7Qix6wYRYGuSb//FlJvVxVlS/hbQIagfhJMll3lqWv9zzV1H63E7Y/vvmuxlrXuQ==", null, false, "9afde616-e3be-4c48-99ff-f27959465e38", false, "Jacob@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
