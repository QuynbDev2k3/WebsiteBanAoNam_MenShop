using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.MaHD).IsRequired();
            builder.Property(r => r.TienShip).IsRequired();
            builder.Property(r => r.NgayTao).IsRequired();
            builder.Property(r => r.TenNgNhan).IsRequired();
            builder.Property(r => r.SDT).IsRequired();
            builder.Property(r => r.Email).IsRequired();
            builder.Property(r => r.PTThanhToan).IsRequired();
            builder.Property(r => r.TongTien).IsRequired();
            builder.Property(r => r.DiaChi).IsRequired();
            builder.Property(r => r.GhiChu).IsRequired();
            builder.Property(r => r.NgayNhanHang).IsRequired();
            builder.Property(r => r.NgayThanhToan).IsRequired();
            builder.Property(r => r.TrangThai).IsRequired();
            builder.HasMany(p => p.Vouchers).WithMany(p => p.HoaDons);
            builder.HasOne(p => p.DoiTra).WithOne(p => p.HoaDon).HasForeignKey<DoiTra>(p => p.IdHoaDon);
            // builder.HasOne(p => p.LichSuMuaHang).WithOne(p => p.HoaDon).HasForeignKey<LichSuMuaHang>(p => p.IdHoaDon);
            builder.HasOne(p => p.NhanVien).WithMany(p => p.HoaDons).HasForeignKey(p => p.IdNhanVien);
            builder.HasOne(p => p.KhachHang).WithMany(p => p.hoaDons).HasForeignKey(p => p.IdKhachHang);
        }
    }
}
