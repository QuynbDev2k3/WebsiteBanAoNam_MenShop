using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class update_giamgia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinhLuan",
                table: "GiamGias");

            migrationBuilder.DropColumn(
                name: "NgayDanhGia",
                table: "GiamGias");

            migrationBuilder.RenameColumn(
                name: "Sao",
                table: "GiamGias",
                newName: "SoLuong");

            migrationBuilder.AlterColumn<int>(
                name: "trangThai",
                table: "GiamGias",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<double>(
                name: "GiaTri",
                table: "GiamGias",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "GiamGias",
                type: "nvarchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayApDung",
                table: "GiamGias",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayHetHan",
                table: "GiamGias",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ten",
                table: "GiamGias",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaTri",
                table: "GiamGias");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "GiamGias");

            migrationBuilder.DropColumn(
                name: "NgayApDung",
                table: "GiamGias");

            migrationBuilder.DropColumn(
                name: "NgayHetHan",
                table: "GiamGias");

            migrationBuilder.DropColumn(
                name: "Ten",
                table: "GiamGias");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "GiamGias",
                newName: "Sao");

            migrationBuilder.AlterColumn<bool>(
                name: "trangThai",
                table: "GiamGias",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BinhLuan",
                table: "GiamGias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayDanhGia",
                table: "GiamGias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
