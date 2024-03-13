using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class LichSuTichDiemConfiguration : IEntityTypeConfiguration<LichSuTichDiem>
{
    public void Configure(EntityTypeBuilder<LichSuTichDiem> builder)
    {
        builder.HasKey(k => k.Id);
        builder.Property(k => k.Diem).HasColumnType("float").IsRequired();
        builder.Property(k => k.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.KhachHang).WithMany(p => p.lichSuTichDiems).HasForeignKey(p => p.IdKhachHang);
        builder.HasOne(p => p.QuyDoiDiem).WithMany(p => p.LichSuTichDiems).HasForeignKey(p => p.IdQuyDoiDiem);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.LichSuTichDiem).HasForeignKey<LichSuTichDiem>(p => p.IdHoaDon);
    }
}