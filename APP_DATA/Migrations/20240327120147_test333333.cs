using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class test333333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anhs_CtSanPhams_Id",
                table: "anhs");

            migrationBuilder.DropColumn(
                name: "IDAnh",
                table: "CtSanPhams");

            migrationBuilder.AddColumn<Guid>(
                name: "IdCtSanPham",
                table: "anhs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_anhs_IdCtSanPham",
                table: "anhs",
                column: "IdCtSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_anhs_CtSanPhams_IdCtSanPham",
                table: "anhs",
                column: "IdCtSanPham",
                principalTable: "CtSanPhams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anhs_CtSanPhams_IdCtSanPham",
                table: "anhs");

            migrationBuilder.DropIndex(
                name: "IX_anhs_IdCtSanPham",
                table: "anhs");

            migrationBuilder.DropColumn(
                name: "IdCtSanPham",
                table: "anhs");

            migrationBuilder.AddColumn<Guid>(
                name: "IDAnh",
                table: "CtSanPhams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_anhs_CtSanPhams_Id",
                table: "anhs",
                column: "Id",
                principalTable: "CtSanPhams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
