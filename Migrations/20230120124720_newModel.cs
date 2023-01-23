using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class newModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CheckOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckOut_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CheckOut_UserId",
                table: "CheckOut",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CheckOut_ProductId",
                table: "Product",
                column: "ProductId",
                principalTable: "CheckOut",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CheckOut_ProductId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "CheckOut");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9faed20-febe-4a04-80bc-74751842525f", "AQAAAAEAACcQAAAAEBMBZq5MtY5uEdI+vFXR7n++JWpGe2c1ZrNKBvRNXCTzmYJorUs8Zj29YM6ghcnQjw==", "c6192ff9-ed2f-4c5a-9195-6bd405361f6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad1e7e9d-01f7-4c91-be07-2a8fa914ce65", "AQAAAAEAACcQAAAAEAj6wyayYObw9mXFb9QW5zQV4eCNrVc/G132AK0AMFKfNY8aKasv65PfkUQtAunPWQ==", "b3ef389c-9c45-4252-a32f-7940ab50d8f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7ba677d-1a0d-437b-93a3-e1cd0aa180aa", "AQAAAAEAACcQAAAAEGzY60JKZ0vmDl/XIOwgomsKSicyEHVT9vV1L/BODvx/RzubbsUEmU5548WmDVxhxQ==", "51270d7b-80a3-4b1f-8905-f58533aee316" });
        }
    }
}
