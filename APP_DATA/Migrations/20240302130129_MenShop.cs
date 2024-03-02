using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class MenShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chatlieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatlieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CtHoadons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dongia = table.Column<int>(type: "int", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false),
                    trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtHoadons", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "DanhGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sao = table.Column<int>(type: "int", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucSanPhams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSanPhams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "doiTras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDoiTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lydo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HanDoi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doiTras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiamGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sao = table.Column<int>(type: "int", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiamGias", x => x.Id);
                });

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
                name: "hoadons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    TienShip = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenNgNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayNhanHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lichSuMuaHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuMuaHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LichSuTichDiems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoiDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuTichDiems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.Id);
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
                name: "QuyDoiDiems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    TiLeTieuDiem = table.Column<float>(type: "real", nullable: false),
                    TiLeTichDiem = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoiDiems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                name: "vouchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DieuKien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangs_KhachHangs_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CTGioHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GioHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTGioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CTGioHangs_GioHangs_GioHangID",
                        column: x => x.GioHangID,
                        principalTable: "GioHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CTGioHangs_KhachHangs_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_GioHangID",
                table: "CTGioHangs",
                column: "GioHangID");

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_KhachHangID",
                table: "CTGioHangs",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_KhachHangID",
                table: "GioHangs",
                column: "KhachHangID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anhs");

            migrationBuilder.DropTable(
                name: "chatlieus");

            migrationBuilder.DropTable(
                name: "CTGioHangs");

            migrationBuilder.DropTable(
                name: "CtHoadons");

            migrationBuilder.DropTable(
                name: "CtSanPhams");

            migrationBuilder.DropTable(
                name: "DanhGias");

            migrationBuilder.DropTable(
                name: "DanhMucSanPhams");

            migrationBuilder.DropTable(
                name: "doiTras");

            migrationBuilder.DropTable(
                name: "GiamGias");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "hoadons");

            migrationBuilder.DropTable(
                name: "KichCos");

            migrationBuilder.DropTable(
                name: "lichSuMuaHangs");

            migrationBuilder.DropTable(
                name: "LichSuTichDiems");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "QuyDoiDiems");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "KhachHangs");
        }
    }
}
