using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class addedImageUrlToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Product");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc17a16d-d0db-4312-87dd-603cbd3c57e2", "AQAAAAEAACcQAAAAEDJqmbA+3jZOlz93l877nJv/1Qt8QulC2HPvaNWyxPA/mpXsJwXT3romyQD8qKgwXQ==", "dc217194-7861-4f8b-a198-5897d41b9314" });
        }
    }
}
