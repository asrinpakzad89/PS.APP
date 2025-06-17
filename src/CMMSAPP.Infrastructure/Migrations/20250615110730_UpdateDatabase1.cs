using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMMSAPP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCategories_AssetGroups_AssetGroupId",
                table: "AssetCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetCategories_CategoryId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetGroups",
                table: "AssetGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetCategories",
                table: "AssetCategories");

            migrationBuilder.RenameTable(
                name: "AssetGroups",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "AssetCategories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_AssetCategories_AssetGroupId",
                table: "Categories",
                newName: "IX_Categories_AssetGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Categories_CategoryId",
                table: "Assets",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Groups_AssetGroupId",
                table: "Categories",
                column: "AssetGroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Categories_CategoryId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Groups_AssetGroupId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "AssetGroups");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "AssetCategories");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AssetGroupId",
                table: "AssetCategories",
                newName: "IX_AssetCategories_AssetGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetGroups",
                table: "AssetGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetCategories",
                table: "AssetCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCategories_AssetGroups_AssetGroupId",
                table: "AssetCategories",
                column: "AssetGroupId",
                principalTable: "AssetGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetCategories_CategoryId",
                table: "Assets",
                column: "CategoryId",
                principalTable: "AssetCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
