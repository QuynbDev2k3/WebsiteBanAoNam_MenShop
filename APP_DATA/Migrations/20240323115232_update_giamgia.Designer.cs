﻿// <auto-generated />
using System;
using APP_DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APP_DATA.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240323115232_update_giamgia")]
    partial class update_giamgia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APP_DATA.Models.Anh", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("anhs");
                });

            modelBuilder.Entity("APP_DATA.Models.CTGioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GioHangID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdCTSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GioHangID");

                    b.HasIndex("IdCTSanPham");

                    b.ToTable("CTGioHangs");
                });

            modelBuilder.Entity("APP_DATA.Models.CTHoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCTSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("dongia")
                        .HasColumnType("int");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.Property<bool>("trangthai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("CtHoadons");
                });

            modelBuilder.Entity("APP_DATA.Models.CTSanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<Guid>("IDAnh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDDanhGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDGiamGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKichCo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDChatLieu");

                    b.HasIndex("IDGiamGia");

                    b.HasIndex("IDHang");

                    b.HasIndex("IDSanPham")
                        .IsUnique();

                    b.ToTable("CtSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("chatlieus");
                });

            modelBuilder.Entity("APP_DATA.Models.DanhGia", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BinhLuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("NgayDanhGia")
                        .HasColumnType("datetime");

                    b.Property<int>("Sao")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DanhGias");
                });

            modelBuilder.Entity("APP_DATA.Models.DanhMucSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DanhMucSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.DoiTra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("HanDoi")
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Lydo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayDoiTra")
                        .HasColumnType("datetime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon")
                        .IsUnique();

                    b.HasIndex("IdSanPham");

                    b.ToTable("doiTras");
                });

            modelBuilder.Entity("APP_DATA.Models.GiamGia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaTri")
                        .HasColumnType("float");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GiamGias");
                });

            modelBuilder.Entity("APP_DATA.Models.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("APP_DATA.Models.Hang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Hangs");
                });

            modelBuilder.Entity("APP_DATA.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCTHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaHD")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhanHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("PTThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNgNhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TienShip")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("hoadons");
                });

            modelBuilder.Entity("APP_DATA.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Diem")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("APP_DATA.Models.KichCo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ma")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KichCos");
                });

            modelBuilder.Entity("APP_DATA.Models.LichSuMuaHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon")
                        .IsUnique()
                        .HasFilter("[IdHoaDon] IS NOT NULL");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("lichSuMuaHangs");
                });

            modelBuilder.Entity("APP_DATA.Models.LichSuTichDiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Diem")
                        .HasColumnType("float");

                    b.Property<Guid?>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdQuyDoiDiem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon")
                        .IsUnique()
                        .HasFilter("[IdHoaDon] IS NOT NULL");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdQuyDoiDiem");

                    b.ToTable("LichSuTichDiems");
                });

            modelBuilder.Entity("APP_DATA.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TenMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("mauSacs");
                });

            modelBuilder.Entity("APP_DATA.Models.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("IDRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDRole");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("APP_DATA.Models.QuyDoiDiem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("TiLeTichDiem")
                        .HasColumnType("real");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("QuyDoiDiems");
                });

            modelBuilder.Entity("APP_DATA.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("APP_DATA.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DanhMucSanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<Guid>("IDDanhMucSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DanhMucSanPhamId");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.Voucher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DieuKien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiaTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangthai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("vouchers");
                });

            modelBuilder.Entity("CTSanPhamKichCo", b =>
                {
                    b.Property<Guid>("cTSanPhamsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("kichCosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("cTSanPhamsID", "kichCosId");

                    b.HasIndex("kichCosId");

                    b.ToTable("CTSanPhamKichCo");
                });

            modelBuilder.Entity("CTSanPhamMauSac", b =>
                {
                    b.Property<Guid>("MauSacsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cTSanPhamsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MauSacsId", "cTSanPhamsID");

                    b.HasIndex("cTSanPhamsID");

                    b.ToTable("CTSanPhamMauSac");
                });

            modelBuilder.Entity("CTSanPhamVoucher", b =>
                {
                    b.Property<Guid>("CTSanPhamsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("vouchersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CTSanPhamsID", "vouchersId");

                    b.HasIndex("vouchersId");

                    b.ToTable("CTSanPhamVoucher");
                });

            modelBuilder.Entity("HoaDonVoucher", b =>
                {
                    b.Property<Guid>("HoaDonsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VouchersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HoaDonsId", "VouchersId");

                    b.HasIndex("VouchersId");

                    b.ToTable("HoaDonVoucher");
                });

            modelBuilder.Entity("APP_DATA.Models.Anh", b =>
                {
                    b.HasOne("APP_DATA.Models.CTSanPham", "CTSanPhams")
                        .WithMany("Anhs")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CTSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.CTGioHang", b =>
                {
                    b.HasOne("APP_DATA.Models.GioHang", "GioHang")
                        .WithMany("cTGioHangs")
                        .HasForeignKey("GioHangID");

                    b.HasOne("APP_DATA.Models.CTSanPham", "CTSanPhams")
                        .WithMany("CTGioHang")
                        .HasForeignKey("IdCTSanPham");

                    b.Navigation("CTSanPhams");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("APP_DATA.Models.CTHoaDon", b =>
                {
                    b.HasOne("APP_DATA.Models.HoaDon", "HoaDon")
                        .WithMany("CTHoaDons")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("APP_DATA.Models.CTSanPham", b =>
                {
                    b.HasOne("APP_DATA.Models.ChatLieu", "ChatLieu")
                        .WithMany("CTSanPhams")
                        .HasForeignKey("IDChatLieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.GiamGia", "GiamGia")
                        .WithMany("CTSanPhams")
                        .HasForeignKey("IDGiamGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.Hang", "hang")
                        .WithMany("ctsanphams")
                        .HasForeignKey("IDHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.SanPham", "sanpham")
                        .WithOne("ctsanpham")
                        .HasForeignKey("APP_DATA.Models.CTSanPham", "IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatLieu");

                    b.Navigation("GiamGia");

                    b.Navigation("hang");

                    b.Navigation("sanpham");
                });

            modelBuilder.Entity("APP_DATA.Models.DanhGia", b =>
                {
                    b.HasOne("APP_DATA.Models.CTSanPham", "CTSanPhams")
                        .WithMany("DanhGias")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CTSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.DoiTra", b =>
                {
                    b.HasOne("APP_DATA.Models.HoaDon", "HoaDon")
                        .WithOne("DoiTra")
                        .HasForeignKey("APP_DATA.Models.DoiTra", "IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.SanPham", "SanPham")
                        .WithMany("DoiTras")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("APP_DATA.Models.HoaDon", b =>
                {
                    b.HasOne("APP_DATA.Models.KhachHang", "KhachHang")
                        .WithMany("hoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("APP_DATA.Models.KhachHang", b =>
                {
                    b.HasOne("APP_DATA.Models.GioHang", "GioHang")
                        .WithOne("KhachHang")
                        .HasForeignKey("APP_DATA.Models.KhachHang", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("APP_DATA.Models.LichSuMuaHang", b =>
                {
                    b.HasOne("APP_DATA.Models.HoaDon", "HoaDon")
                        .WithOne("LichSuMuaHang")
                        .HasForeignKey("APP_DATA.Models.LichSuMuaHang", "IdHoaDon");

                    b.HasOne("APP_DATA.Models.KhachHang", "KhachHang")
                        .WithMany("lichSuMuaHangs")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("APP_DATA.Models.LichSuTichDiem", b =>
                {
                    b.HasOne("APP_DATA.Models.HoaDon", "HoaDon")
                        .WithOne("LichSuTichDiem")
                        .HasForeignKey("APP_DATA.Models.LichSuTichDiem", "IdHoaDon");

                    b.HasOne("APP_DATA.Models.KhachHang", "KhachHang")
                        .WithMany("lichSuTichDiems")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.QuyDoiDiem", "QuyDoiDiem")
                        .WithMany("LichSuTichDiems")
                        .HasForeignKey("IdQuyDoiDiem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("KhachHang");

                    b.Navigation("QuyDoiDiem");
                });

            modelBuilder.Entity("APP_DATA.Models.NhanVien", b =>
                {
                    b.HasOne("APP_DATA.Models.Role", "Role")
                        .WithMany("NhanViens")
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("APP_DATA.Models.SanPham", b =>
                {
                    b.HasOne("APP_DATA.Models.DanhMucSanPham", "DanhMucSanPham")
                        .WithMany("SanPhams")
                        .HasForeignKey("DanhMucSanPhamId");

                    b.Navigation("DanhMucSanPham");
                });

            modelBuilder.Entity("CTSanPhamKichCo", b =>
                {
                    b.HasOne("APP_DATA.Models.CTSanPham", null)
                        .WithMany()
                        .HasForeignKey("cTSanPhamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.KichCo", null)
                        .WithMany()
                        .HasForeignKey("kichCosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CTSanPhamMauSac", b =>
                {
                    b.HasOne("APP_DATA.Models.MauSac", null)
                        .WithMany()
                        .HasForeignKey("MauSacsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.CTSanPham", null)
                        .WithMany()
                        .HasForeignKey("cTSanPhamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CTSanPhamVoucher", b =>
                {
                    b.HasOne("APP_DATA.Models.CTSanPham", null)
                        .WithMany()
                        .HasForeignKey("CTSanPhamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.Voucher", null)
                        .WithMany()
                        .HasForeignKey("vouchersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HoaDonVoucher", b =>
                {
                    b.HasOne("APP_DATA.Models.HoaDon", null)
                        .WithMany()
                        .HasForeignKey("HoaDonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Models.Voucher", null)
                        .WithMany()
                        .HasForeignKey("VouchersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APP_DATA.Models.CTSanPham", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("CTGioHang");

                    b.Navigation("DanhGias");
                });

            modelBuilder.Entity("APP_DATA.Models.ChatLieu", b =>
                {
                    b.Navigation("CTSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.DanhMucSanPham", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.GiamGia", b =>
                {
                    b.Navigation("CTSanPhams");
                });

            modelBuilder.Entity("APP_DATA.Models.GioHang", b =>
                {
                    b.Navigation("KhachHang");

                    b.Navigation("cTGioHangs");
                });

            modelBuilder.Entity("APP_DATA.Models.Hang", b =>
                {
                    b.Navigation("ctsanphams");
                });

            modelBuilder.Entity("APP_DATA.Models.HoaDon", b =>
                {
                    b.Navigation("CTHoaDons");

                    b.Navigation("DoiTra");

                    b.Navigation("LichSuMuaHang");

                    b.Navigation("LichSuTichDiem");
                });

            modelBuilder.Entity("APP_DATA.Models.KhachHang", b =>
                {
                    b.Navigation("hoaDons");

                    b.Navigation("lichSuMuaHangs");

                    b.Navigation("lichSuTichDiems");
                });

            modelBuilder.Entity("APP_DATA.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("APP_DATA.Models.QuyDoiDiem", b =>
                {
                    b.Navigation("LichSuTichDiems");
                });

            modelBuilder.Entity("APP_DATA.Models.Role", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("APP_DATA.Models.SanPham", b =>
                {
                    b.Navigation("DoiTras");

                    b.Navigation("ctsanpham");
                });
#pragma warning restore 612, 618
        }
    }
}
