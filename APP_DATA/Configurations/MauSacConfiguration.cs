using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
{
    public void Configure(EntityTypeBuilder<MauSac> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(50)").IsRequired();
        builder.Property(p => p.TenMauSac).HasColumnType("nvarchar(50)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
    }
}