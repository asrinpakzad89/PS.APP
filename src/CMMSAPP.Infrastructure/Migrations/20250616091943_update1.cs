using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMMSAPP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Groups_AssetGroupId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "AssetGroupId",
                table: "Categories",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AssetGroupId",
                table: "Categories",
                newName: "IX_Categories_GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Groups_GroupId",
                table: "Categories",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Groups_GroupId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Categories",
                newName: "AssetGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_GroupId",
                table: "Categories",
                newName: "IX_Categories_AssetGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Groups_AssetGroupId",
                table: "Categories",
                column: "AssetGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
