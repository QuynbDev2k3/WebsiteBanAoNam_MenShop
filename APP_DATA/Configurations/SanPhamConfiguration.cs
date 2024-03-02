using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
{
    public void Configure(EntityTypeBuilder<SanPham> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ma).HasColumnType("varchar(50)").IsRequired();
        builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.Gia).HasColumnType("float").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
    }
}