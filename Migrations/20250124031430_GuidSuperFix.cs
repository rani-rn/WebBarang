using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barang.Migrations
{
    /// <inheritdoc />
    public partial class GuidSuperFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sections_SectionId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SectionId",
                table: "Categories");

            migrationBuilder.AlterColumn<Guid>(
                name: "SectionId",
                table: "Sections",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SectionId",
                table: "Items",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Items",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectionId1",
                table: "Categories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SectionId1",
                table: "Categories",
                column: "SectionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sections_SectionId1",
                table: "Categories",
                column: "SectionId1",
                principalTable: "Sections",
                principalColumn: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sections_SectionId1",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SectionId1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SectionId1",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Sections",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Items",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Items",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SectionId",
                table: "Categories",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sections_SectionId",
                table: "Categories",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId");
        }
    }
}
