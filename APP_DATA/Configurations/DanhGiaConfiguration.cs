using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class DanhGiaConfiguration : IEntityTypeConfiguration<DanhGia>
{
    public void Configure(EntityTypeBuilder<DanhGia> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.BinhLuan).HasColumnType("nvarchar(500)").IsRequired();
        builder.Property(r => r.Sao).HasColumnType("int").IsRequired();
        builder.Property(r => r.NgayDanhGia).HasColumnType("datetime").IsRequired();
        builder.Property(r => r.TrangThai).HasColumnType("int").IsRequired();
        builder.HasOne(c => c.CTSanPhams).WithMany(c => c.DanhGias).HasForeignKey(c => c.Id);
    }
}