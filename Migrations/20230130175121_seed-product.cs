using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class seedproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 1, 30, 18, 51, 21, 391, DateTimeKind.Local).AddTicks(3583), "86e8f4e1-f7e7-4955-9275-6e4d6634d72e", "AQAAAAEAACcQAAAAEB8l6jhsTw0b1pnx4xlaLw/W79THBBn05YMzgutW+9Bqr+k3mX3PItLlC8uszf32Lg==", "5d206929-5484-4c52-845d-feddcecc3d70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e191cfb-b044-4057-af27-100784d7cae2", "AQAAAAEAACcQAAAAEKJQSnMb+D8lJXsFj7Q3Y7roghJ/7l9NcZrSLT2uWeOZfmM2wYdIpTAUmS2EJPcwww==", "4f825544-1f55-4dca-99ad-5a1491271675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb36b685-a3a0-4605-83aa-116beddff78b", "AQAAAAEAACcQAAAAEMI4sU54ukGuie1FtcKg/3WcwIrCCZ20iG8MbHn4csqXP19CweUbweLAI4LWnGBBCQ==", "cfba4cf1-b324-435d-a296-09934347307a" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AvalaibleDate", "ImageUrl", "Price", "ProductDescription", "ProductName", "TimeToFinnish" },
                values: new object[,]
                {
                    { 1, null, "", 22.0, "Nagellack som är coolt", "Nagellack", "60" },
                    { 2, null, "", 300.0, "Manikyr för coola män", "Manikyr", "30" },
                    { 3, null, "", 150.0, "Mer volym för dina fransar", "Volymfransar", "90" },
                    { 4, null, "", 200.0, "Om du vill ha ont och betala för det", "Massage", "120" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 1, 23, 9, 48, 3, 834, DateTimeKind.Local).AddTicks(2701), "2bdfa748-b637-48ef-abbe-2edd285a083d", "AQAAAAEAACcQAAAAEOeqvUZhdBf4xrABrDVAKbXtLOsJwmDXfOjVmbuQY9PR/GZgUB7kDzul4Imp7EKMVw==", "8f257ac6-1acf-4ff2-95b2-272a459d47c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f25ac12-600b-4c15-bc12-51a6ab559170", "AQAAAAEAACcQAAAAECgd239mJ4QG3OP1mlh1qUOW3N2FKH5TKVXS1gQQ/VasL9E4l1+ifRU3DRShWkGWsQ==", "db828982-6617-451e-a963-b98ed47daa52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b1a54ed-8d80-4818-aba5-888223268660", "AQAAAAEAACcQAAAAEC506Q3tNIz6QY34/G05KS9r5bfc8wPK74Riil12iaSoeR7o11MsrsPeXYBlvZsyrw==", "940c780b-6cd9-4b24-9e6e-7507736ebe23" });
        }
    }
}
