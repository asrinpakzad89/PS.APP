using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMMSAPP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tools");

            migrationBuilder.AddColumn<Guid>(
                name: "ToolTypeId",
                table: "Tools",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ToolTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisable = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolTypeId",
                table: "Tools",
                column: "ToolTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ToolTypes_Title",
                table: "ToolTypes",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_ToolTypes_ToolTypeId",
                table: "Tools",
                column: "ToolTypeId",
                principalTable: "ToolTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_ToolTypes_ToolTypeId",
                table: "Tools");

            migrationBuilder.DropTable(
                name: "ToolTypes");

            migrationBuilder.DropIndex(
                name: "IX_Tools_ToolTypeId",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "ToolTypeId",
                table: "Tools");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tools",
                type: "integer",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }
    }
}
