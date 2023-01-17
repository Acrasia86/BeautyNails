using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class addeduserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9082a36d-5a00-4109-a05a-826c5ba39121", "AQAAAAEAACcQAAAAEG8AVgHsnjGpW2e85VUJ5tyRsMiXNXjTrvOmORyos8s9DeKpA0dttE3NN8T9aVuJ6Q==", "e181fbdf-1d4f-45cb-9c69-24def8afc8be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78137979-3954-4bde-a08a-1818c441b22c", "AQAAAAEAACcQAAAAEK7njVu14xXo0TrAQI5G4WwFlX1MXLCMaJpRtPB7ZjVZDghwusqESvJZw86zKU3lXA==", "34168041-1e30-425b-ab81-d2bed39259b4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3", 0, "Blabla", "bc17a16d-d0db-4312-87dd-603cbd3c57e2", "User", "User@mail.com", true, false, null, "USER@MAIL.COM", "USER@MAIL.COM", "AQAAAAEAACcQAAAAEDJqmbA+3jZOlz93l877nJv/1Qt8QulC2HPvaNWyxPA/mpXsJwXT3romyQD8qKgwXQ==", null, false, "dc217194-7861-4f8b-a198-5897d41b9314", false, "User@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2098d001-cf3d-4f7e-91dd-7d14cde770e3", "AQAAAAEAACcQAAAAEFa+j5s2x4HEGbe1y0KavAXDjsYPAysErouKJrGYDRS75ebSCzo3xs8p6ZBqlqc5mQ==", "635064e9-3d25-47fd-9bd2-26801dbecf0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a9efbe1-7409-417a-8f4a-a5bbaf7ab029", "AQAAAAEAACcQAAAAEArhtEkx44lbbht/no/TcHAzJIvOicqK/Rz0KJX1RNyVHvm0fuNtpS/gWHD6ZOkwKQ==", "841aeb5d-1e3a-47bb-a386-42f1c398597f" });
        }
    }
}
