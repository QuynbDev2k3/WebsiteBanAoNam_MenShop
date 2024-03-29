﻿using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class CTSanPhamConfiguration : IEntityTypeConfiguration<CTSanPham>
{
    public void Configure(EntityTypeBuilder<CTSanPham> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(50)").IsRequired();
        builder.Property(p => p.GiaBan).HasColumnType("float").IsRequired();
        builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
        builder.Property(p => p.Age).HasColumnType("int").IsRequired();
        builder.Property(p => p.NgayTao).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.MoTa).HasColumnType("nvarchar(max)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.ChatLieu).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDChatLieu);
        builder.HasOne(p => p.hang).WithMany(p => p.ctsanphams).HasForeignKey(p => p.IDHang);
        builder.HasMany(p => p.vouchers).WithMany(p => p.CTSanPhams);
        builder.HasMany(p => p.MauSacs).WithMany(p => p.cTSanPhams);
        builder.HasMany(p => p.kichCos).WithMany(p => p.cTSanPhams);
        builder.HasOne(p => p.ChatLieu).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDChatLieu);
        builder.HasOne(p => p.GiamGia).WithMany(p => p.CTSanPhams).HasForeignKey(p => p.IDGiamGia);
        builder.HasMany(p => p.Anhs).WithOne(p => p.CTSanPhams).HasForeignKey(p => p.Id);
        builder.HasOne(p => p.sanpham).WithOne(p => p.ctsanpham).HasForeignKey<CTSanPham>(p => p.IDSanPham);
    }
}