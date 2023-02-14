using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 2, 14, 8, 4, 39, 863, DateTimeKind.Local).AddTicks(8377), "33a86fa0-56e4-4c03-b18d-6a49c030ae96", "AQAAAAEAACcQAAAAEDiNFaSGsFn32uTXJniS0SaKbPhFjwSPOig/dNn4dsJJrhGEGiP2S38p2DbXSHqLgg==", "bb3a9149-3091-457f-8c3f-19620835d3a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9b00243-13d1-4610-8a0d-52d69cd60472", "AQAAAAEAACcQAAAAEFyp9G4fusq/NeCzCQUT8iLd8pGlWbEdVe2JqItPVhCGH1E3PZpIFX9Ige0nywztew==", "54a08e46-5667-45be-95b5-69ea9a49b1ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7c84a6-4fe7-4dea-b614-add2b69a3dea", "AQAAAAEAACcQAAAAEFjA7TT0u+kT75Ta0t6pwh3oVLPW+WDZ3PHjfCQYvHOtQBvxAbDIbOWW/raKbjxJLQ==", "c672bde3-d455-4b6f-b7c8-5ed9304b9c4c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "BirthDay", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4", 0, "Blabla", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "ad855c17-a147-4b65-8f67-474fe5555732", "Henke", "Henrik@mail.com", true, false, null, "HENRIK@MAIL.COM", "HENRIK@MAIL.COM", "AQAAAAEAACcQAAAAEMReIQk5vWYcSj4nSflzk9KjH3FYPP9IdJBBEJjSpr3JdsoFd8IIICJue/f5/nj3kA==", null, false, "fef5db64-0d83-48fe-b21c-af9aee34f415", false, "Henrik@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 2, 14, 5, 21, 3, 194, DateTimeKind.Local).AddTicks(9487), "200a422d-d619-4041-934b-4a2095119c0b", "AQAAAAEAACcQAAAAEPO/14J8oS7kXFxr4qZLsB5435fScmm64+qgdqPFgR1XGyG8uXICCIceTqca70nm3A==", "5fda2e39-f93a-47ec-8825-3d6126ff2797" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2859620f-9930-423b-9196-311a85e2f0f8", "AQAAAAEAACcQAAAAEBW37ofwWfZTUzitvZjmsys2lrYy1yCmtVmLTZjrJl4DIhrrpEtSVARgGbSzJTcOJg==", "53bb8984-dc87-47eb-a77e-f9b86fc914cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebc85eb7-9db2-455b-beec-48bc6323b555", "AQAAAAEAACcQAAAAEMbFO8TyLZNrzdNP5wDyvNYW7K38Wke3yT6oN6YuDKE9YC+6fYFaZ04C0dm5QaIc/g==", "873e57f6-0aea-4afc-9a35-523286c3a04d" });
        }
    }
}
