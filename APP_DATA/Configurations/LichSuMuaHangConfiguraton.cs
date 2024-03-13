using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class LichSuMuaHangConfiguraton : IEntityTypeConfiguration<LichSuMuaHang>
{
    public void Configure(EntityTypeBuilder<LichSuMuaHang> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.KhachHang).WithMany(p => p.lichSuMuaHangs).HasForeignKey(p => p.IdKhachHang);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.LichSuMuaHang).HasForeignKey<LichSuMuaHang>(p => p.IdHoaDon);

    }
}