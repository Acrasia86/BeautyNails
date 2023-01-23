using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class Birthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CheckOut_ProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "CheckOut");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CheckOut_ProductId",
                table: "CheckOut",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckOut_Product_ProductId",
                table: "CheckOut",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckOut_Product_ProductId",
                table: "CheckOut");

            migrationBuilder.DropIndex(
                name: "IX_CheckOut_ProductId",
                table: "CheckOut");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "CheckOut",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa311644-1c82-42c7-9fe9-cb3bbafe8129", "AQAAAAEAACcQAAAAEFAgbVPQfw4YQ8IxWyMzORzw9AXPLIV9cC3ud8CLOGjDLDxLGRVOEUAAiM8Hgmr9gw==", "74652880-bd70-44ca-b0b5-ba3cc6697cd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cae6a67-b978-4efd-9bdf-03451b2ce37b", "AQAAAAEAACcQAAAAEAjiYSP3k6t+k4LY5lLfAnEgoT10+YQmPhmB0OiqZqe92FrnjbzBFr3gTSZBWV5XBg==", "8fd9152f-18a2-4753-91e3-853b0a5d6f39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4637944-4e6d-481b-9773-2347ff23b4fa", "AQAAAAEAACcQAAAAEK09UcmiBBhIVPjdomOgTI3rf7Me1sh3o6kKQIJDYr5oRKTGCtM0309d3XcXB1Pl5Q==", "2a91edd6-fa6c-42b0-8c7c-d4d488d8c05b" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CheckOut_ProductId",
                table: "Product",
                column: "ProductId",
                principalTable: "CheckOut",
                principalColumn: "Id");
        }
    }
}
