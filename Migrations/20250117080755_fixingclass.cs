using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barang.Migrations
{
    /// <inheritdoc />
    public partial class fixingclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Items",
                newName: "CategoryId1");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Categories",
                newName: "SectionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId1",
                table: "Items",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SectionIdId",
                table: "Categories",
                column: "SectionIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sections_SectionIdId",
                table: "Categories",
                column: "SectionIdId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryId1",
                table: "Items",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sections_SectionIdId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CategoryId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SectionIdId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId1",
                table: "Items",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "SectionIdId",
                table: "Categories",
                newName: "SectionId");
        }
    }
}
