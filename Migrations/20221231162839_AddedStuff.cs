using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyNails.Migrations
{
    public partial class AddedStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Person_PersonId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Review_PersonId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ClosingHours",
                table: "About");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "About");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "DaysOpen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaysAndTimeOpen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOpen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DaysOpen_About_AboutId",
                        column: x => x.AboutId,
                        principalTable: "About",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "Blabla", "96ab569f-6f68-4593-9526-b9e279993cb9", "Jp", "Jacob@mail.com", true, false, null, "JACOB@MAIL.COM", "JACOB@MAIL.COM", "AQAAAAEAACcQAAAAEJ+oInZNQIsRTI3JMuqFMmouSHIUPCcnkIL7qKcb/LvgREn+SOcj2FdFuJAUiBEl3Q==", null, false, "7a1200e1-5b41-4157-bd86-1dbd066a6f4f", false, "Jacob@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.CreateIndex(
                name: "IX_DaysOpen_AboutId",
                table: "DaysOpen",
                column: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysOpen");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingHours",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningHours",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_PersonId",
                table: "Review",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Person_PersonId",
                table: "Review",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
