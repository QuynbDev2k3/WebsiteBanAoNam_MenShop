using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class Update_CTSanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtSanPhams_Hangs_HangID",
                table: "CtSanPhams");

            migrationBuilder.DropIndex(
                name: "IX_CtSanPhams_HangID",
                table: "CtSanPhams");

            migrationBuilder.DropColumn(
                name: "HangID",
                table: "CtSanPhams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HangID",
                table: "CtSanPhams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_HangID",
                table: "CtSanPhams",
                column: "HangID");

            migrationBuilder.AddForeignKey(
                name: "FK_CtSanPhams_Hangs_HangID",
                table: "CtSanPhams",
                column: "HangID",
                principalTable: "Hangs",
                principalColumn: "ID");
        }
    }
}
