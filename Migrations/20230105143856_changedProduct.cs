using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class changedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Product",
                newName: "TimeToFinnish");

            migrationBuilder.AddColumn<DateTime>(
                name: "AvalaibleDate",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27e1adb5-af00-4df6-b8c1-13e8638c51eb", "AQAAAAEAACcQAAAAEDTBgXkv3TSX2ZrQIOn2iFPJLl/YrbX2vdA86CZPDzAzWl41FIC72jm91FLDudh2Yw==", "35033782-3c43-4cbb-8ff2-716c01d65a48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06e1858a-ee62-4ed9-8622-1ce4bb4f61f5", "AQAAAAEAACcQAAAAEEX8X3wCq/I9UcJ4euGa03dx4fGQ4YUOgSjJG4UKTgtwikRT1vcJt1RnXdrV/CQ2mA==", "cb2d5d15-7227-4490-aab7-8b3839af5cae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvalaibleDate",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "TimeToFinnish",
                table: "Product",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a15e38c-2425-40e5-b184-5789d0e031c9", "AQAAAAEAACcQAAAAEMv39IYfmiKehKOYfg8SH4W8rN8wF/wThWCPCGrEdZlouUoKOm023bdhXGiPxp3TOw==", "85674d1a-62b3-47ae-a0ea-dfb240464a2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0f6fd9-5e09-4480-83e4-6407952471e6", "AQAAAAEAACcQAAAAEN6W6VVS8SBc3LpqBcJ/YNnpAF5GUEMsOxjhKPn2t3N1+w4rHUJoKh+JTojTiUqPjA==", "86326a29-6689-4376-b776-19805f223b94" });
        }
    }
}
