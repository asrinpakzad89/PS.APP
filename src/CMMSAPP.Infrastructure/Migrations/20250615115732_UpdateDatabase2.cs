using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMMSAPP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Manufacturers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "InstalledAssetCodings",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "InstalledAssetCodes",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FileResources",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Dimensions",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_Code",
                table: "Visits",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_Title",
                table: "Visits",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_Code",
                table: "Tools",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_Title",
                table: "Tools",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StandardParts_Code",
                table: "StandardParts",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StandardParts_Title",
                table: "StandardParts",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Code",
                table: "Materials",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Title",
                table: "Materials",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_CompanyName",
                table: "Manufacturers",
                column: "CompanyName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Code",
                table: "Locations",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Title",
                table: "Locations",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationCodings_Code",
                table: "LocationCodings",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstalledAssetCodings_Code",
                table: "InstalledAssetCodings",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstalledAssetCodings_Title",
                table: "InstalledAssetCodings",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstalledAssetCodes_Code",
                table: "InstalledAssetCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Title",
                table: "Groups",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_Title",
                table: "Dimensions",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Code",
                table: "Categories",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Title",
                table: "Categories",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_Code",
                table: "Breakdowns",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_Title",
                table: "Breakdowns",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_Code",
                table: "Assets",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_Title",
                table: "Assets",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Visits_Code",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_Title",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Tools_Code",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_Title",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_StandardParts_Code",
                table: "StandardParts");

            migrationBuilder.DropIndex(
                name: "IX_StandardParts_Title",
                table: "StandardParts");

            migrationBuilder.DropIndex(
                name: "IX_Materials_Code",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_Title",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Manufacturers_CompanyName",
                table: "Manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Code",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Title",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_LocationCodings_Code",
                table: "LocationCodings");

            migrationBuilder.DropIndex(
                name: "IX_InstalledAssetCodings_Code",
                table: "InstalledAssetCodings");

            migrationBuilder.DropIndex(
                name: "IX_InstalledAssetCodings_Title",
                table: "InstalledAssetCodings");

            migrationBuilder.DropIndex(
                name: "IX_InstalledAssetCodes_Code",
                table: "InstalledAssetCodes");

            migrationBuilder.DropIndex(
                name: "IX_Groups_Title",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Dimensions_Title",
                table: "Dimensions");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Code",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Title",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_Code",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_Title",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Assets_Code",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_Title",
                table: "Assets");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Manufacturers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "InstalledAssetCodings",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "InstalledAssetCodes",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "FileResources",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Dimensions",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);
        }
    }
}
