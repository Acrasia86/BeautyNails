using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class ChangedCheckoutModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvalaibleDate",
                table: "Product");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookedDate",
                table: "CheckOut",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "DailySum",
                table: "CheckOut",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MonthlySum",
                table: "CheckOut",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BirthDay", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2023, 2, 2, 1, 9, 50, 277, DateTimeKind.Local).AddTicks(6173), "4fcdec70-a4ed-452a-9d4e-2750139bf2ae", "AQAAAAEAACcQAAAAEKS5H4Nil4p7tuUY7pHPwqKjO9o5YuRyTriCMns2/F1OgpoBBCUgWQMZewDqYeLX4w==", "16b69820-5757-4104-817d-98d76e26b1bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3187ce0-34aa-4feb-8c1a-306a7d2b3721", "AQAAAAEAACcQAAAAEMnZx+U54tUKA7Elq2GxNK8ALHBcjpEk4wQv8a3lGP2xrmrFsJvtFerg5CSH9XaCqQ==", "bf48dcb1-13bf-42e7-82c6-6f506601bfe9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929eb702-b71b-489e-a343-c957e0c407d6", "AQAAAAEAACcQAAAAEAkS2/BWdgTdueBrA+IaG27Bv8b4QSeF/q1MsjY15QT2itUr4IESinkXQnYGTL1UqQ==", "e31cb8ee-3116-4610-b236-218fbc92fb37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedDate",
                table: "CheckOut");

            migrationBuilder.DropColumn(
                name: "DailySum",
                table: "CheckOut");

            migrationBuilder.DropColumn(
                name: "MonthlySum",
                table: "CheckOut");

            migrationBuilder.AddColumn<DateTime>(
                name: "AvalaibleDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

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
        }
    }
}
