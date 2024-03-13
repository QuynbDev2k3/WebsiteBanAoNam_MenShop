using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class DoiTraConfiguration : IEntityTypeConfiguration<DoiTra>
{
    public void Configure(EntityTypeBuilder<DoiTra> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.NgayDoiTra).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.Lydo).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.HanDoi).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.SanPham).WithMany(p => p.DoiTras).HasForeignKey(p => p.IdSanPham);
        builder.HasOne(p => p.HoaDon).WithOne(p => p.DoiTra).HasForeignKey<DoiTra>(p => p.IdHoaDon);
    }
}