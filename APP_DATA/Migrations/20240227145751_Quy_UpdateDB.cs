using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class Quy_UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDDanhMucSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CtSanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDLoaiSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDDanhGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtSanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_Hangs_IDHang",
                        column: x => x.IDHang,
                        principalTable: "Hangs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_SanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDHang",
                table: "CtSanPhams",
                column: "IDHang");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDSanPham",
                table: "CtSanPhams",
                column: "IDSanPham",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CtSanPhams");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
