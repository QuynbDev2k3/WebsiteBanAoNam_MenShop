using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    /// <inheritdoc />
    public partial class TA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatlieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatlieus", x => x.Id);
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
                name: "GioHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.Id);
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
                name: "KichCos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Ma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(50)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoiDiems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
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
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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
                    trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.Id);
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
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    DanhMucSanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucSanPhams_DanhMucSanPhamId",
                        column: x => x.DanhMucSanPhamId,
                        principalTable: "DanhMucSanPhams",
                        principalColumn: "Id");
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
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHangs_GioHangs_Id",
                        column: x => x.Id,
                        principalTable: "GioHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_NhanViens_Roles_IDRole",
                        column: x => x.IDRole,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    HangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtSanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_GiamGias_IDGiamGia",
                        column: x => x.IDGiamGia,
                        principalTable: "GiamGias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtSanPhams_Hangs_HangID",
                        column: x => x.HangID,
                        principalTable: "Hangs",
                        principalColumn: "ID");
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
                    table.ForeignKey(
                        name: "FK_CtSanPhams_chatlieus_IDChatLieu",
                        column: x => x.IDChatLieu,
                        principalTable: "chatlieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoadons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCTHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoadons_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoadons_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "anhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anhs_CtSanPhams_Id",
                        column: x => x.Id,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTGioHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GioHangID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCTSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTGioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CTGioHangs_CtSanPhams_IdCTSanPham",
                        column: x => x.IdCTSanPham,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CTGioHangs_GioHangs_GioHangID",
                        column: x => x.GioHangID,
                        principalTable: "GioHangs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamKichCo",
                columns: table => new
                {
                    cTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kichCosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamKichCo", x => new { x.cTSanPhamsID, x.kichCosId });
                    table.ForeignKey(
                        name: "FK_CTSanPhamKichCo_CtSanPhams_cTSanPhamsID",
                        column: x => x.cTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamKichCo_KichCos_kichCosId",
                        column: x => x.kichCosId,
                        principalTable: "KichCos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamMauSac",
                columns: table => new
                {
                    MauSacsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamMauSac", x => new { x.MauSacsId, x.cTSanPhamsID });
                    table.ForeignKey(
                        name: "FK_CTSanPhamMauSac_CtSanPhams_cTSanPhamsID",
                        column: x => x.cTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamMauSac_mauSacs_MauSacsId",
                        column: x => x.MauSacsId,
                        principalTable: "mauSacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTSanPhamVoucher",
                columns: table => new
                {
                    CTSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vouchersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTSanPhamVoucher", x => new { x.CTSanPhamsID, x.vouchersId });
                    table.ForeignKey(
                        name: "FK_CTSanPhamVoucher_CtSanPhams_CTSanPhamsID",
                        column: x => x.CTSanPhamsID,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTSanPhamVoucher_vouchers_vouchersId",
                        column: x => x.vouchersId,
                        principalTable: "vouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Sao = table.Column<int>(type: "int", nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhGias_CtSanPhams_Id",
                        column: x => x.Id,
                        principalTable: "CtSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtHoadons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CtHoadons_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doiTras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDoiTra = table.Column<DateTime>(type: "datetime", nullable: false),
                    Lydo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HanDoi = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doiTras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_doiTras_SanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doiTras_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonVoucher",
                columns: table => new
                {
                    HoaDonsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VouchersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonVoucher", x => new { x.HoaDonsId, x.VouchersId });
                    table.ForeignKey(
                        name: "FK_HoaDonVoucher_hoadons_HoaDonsId",
                        column: x => x.HoaDonsId,
                        principalTable: "hoadons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonVoucher_vouchers_VouchersId",
                        column: x => x.VouchersId,
                        principalTable: "vouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lichSuMuaHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuMuaHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lichSuMuaHangs_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lichSuMuaHangs_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LichSuTichDiems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoiDiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Diem = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuTichDiems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_QuyDoiDiems_IdQuyDoiDiem",
                        column: x => x.IdQuyDoiDiem,
                        principalTable: "QuyDoiDiems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichSuTichDiems_hoadons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "hoadons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_GioHangID",
                table: "CTGioHangs",
                column: "GioHangID");

            migrationBuilder.CreateIndex(
                name: "IX_CTGioHangs_IdCTSanPham",
                table: "CTGioHangs",
                column: "IdCTSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_CtHoadons_IdHoaDon",
                table: "CtHoadons",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamKichCo_kichCosId",
                table: "CTSanPhamKichCo",
                column: "kichCosId");

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamMauSac_cTSanPhamsID",
                table: "CTSanPhamMauSac",
                column: "cTSanPhamsID");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_HangID",
                table: "CtSanPhams",
                column: "HangID");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDChatLieu",
                table: "CtSanPhams",
                column: "IDChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDGiamGia",
                table: "CtSanPhams",
                column: "IDGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDHang",
                table: "CtSanPhams",
                column: "IDHang");

            migrationBuilder.CreateIndex(
                name: "IX_CtSanPhams_IDSanPham",
                table: "CtSanPhams",
                column: "IDSanPham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CTSanPhamVoucher_vouchersId",
                table: "CTSanPhamVoucher",
                column: "vouchersId");

            migrationBuilder.CreateIndex(
                name: "IX_doiTras_IdHoaDon",
                table: "doiTras",
                column: "IdHoaDon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_doiTras_IdSanPham",
                table: "doiTras",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoadons_IdKhachHang",
                table: "hoadons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoadons_IdNhanVien",
                table: "hoadons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonVoucher_VouchersId",
                table: "HoaDonVoucher",
                column: "VouchersId");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuMuaHangs_IdHoaDon",
                table: "lichSuMuaHangs",
                column: "IdHoaDon",
                unique: true,
                filter: "[IdHoaDon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_lichSuMuaHangs_IdKhachHang",
                table: "lichSuMuaHangs",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IdHoaDon",
                table: "LichSuTichDiems",
                column: "IdHoaDon",
                unique: true,
                filter: "[IdHoaDon] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IdKhachHang",
                table: "LichSuTichDiems",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuTichDiems_IdQuyDoiDiem",
                table: "LichSuTichDiems",
                column: "IdQuyDoiDiem");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IDRole",
                table: "NhanViens",
                column: "IDRole");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_DanhMucSanPhamId",
                table: "SanPhams",
                column: "DanhMucSanPhamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anhs");

            migrationBuilder.DropTable(
                name: "CTGioHangs");

            migrationBuilder.DropTable(
                name: "CtHoadons");

            migrationBuilder.DropTable(
                name: "CTSanPhamKichCo");

            migrationBuilder.DropTable(
                name: "CTSanPhamMauSac");

            migrationBuilder.DropTable(
                name: "CTSanPhamVoucher");

            migrationBuilder.DropTable(
                name: "DanhGias");

            migrationBuilder.DropTable(
                name: "doiTras");

            migrationBuilder.DropTable(
                name: "HoaDonVoucher");

            migrationBuilder.DropTable(
                name: "lichSuMuaHangs");

            migrationBuilder.DropTable(
                name: "LichSuTichDiems");

            migrationBuilder.DropTable(
                name: "KichCos");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "CtSanPhams");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "QuyDoiDiems");

            migrationBuilder.DropTable(
                name: "hoadons");

            migrationBuilder.DropTable(
                name: "GiamGias");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "chatlieus");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "DanhMucSanPhams");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
