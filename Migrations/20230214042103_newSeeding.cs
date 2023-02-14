using System;
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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ImageUrl", "Price", "ProductDescription", "ProductName", "TimeToFinnish" },
                values: new object[,]
                {
                    { 12, "", 600.0, "Test1", "Test1", "100" },
                    { 15, "", 190.0, "Test2", "Test2", "50" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 36, 6, 618, DateTimeKind.Local).AddTicks(8955), "e67951ce-4d9f-42c3-ad52-a2db5a6baee6", "AQAAAAEAACcQAAAAELHq48Rq7BmL0u6cAv6ZeDoYf0M8ZuRi0gyZK40AJ3PJLD4P6KsP8PjG85ZveThgUg==", "72b557cf-a279-447c-bb4f-74c3d4c7f0b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95affd8-ca9a-4249-a4bc-a112de916c2d", "AQAAAAEAACcQAAAAEJq9qknZz7vwL3rZ/rGYdzBA7bqOTBiUmhqcK3HN//5e/cJXXoeFawIKTNW9GTeKWw==", "37f92cc0-e60a-4672-80cd-9748d3a78a01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df467ff4-0f18-4854-ae0b-248a7603616f", "AQAAAAEAACcQAAAAEFF/kn6NbvgpQKnxnldKdaLXFkfxOVXLmH40KivrkYyzh+csNfBaVbJ7oyHAKCq32Q==", "8615831a-82ea-4f03-9c6a-6c00696a3f7a" });
        }
    }
}
