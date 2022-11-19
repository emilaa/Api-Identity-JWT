using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class CreateAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 922, DateTimeKind.Utc).AddTicks(6123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 983, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 922, DateTimeKind.Utc).AddTicks(3999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 983, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 928, DateTimeKind.Utc).AddTicks(38),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 984, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 983, DateTimeKind.Utc).AddTicks(3856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 922, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 983, DateTimeKind.Utc).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 922, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 19, 12, 27, 59, 984, DateTimeKind.Utc).AddTicks(2915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 19, 12, 32, 40, 928, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
