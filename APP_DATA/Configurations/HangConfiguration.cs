using APP_DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APP_DATA.Configurations;

public class HangConfiguration : IEntityTypeConfiguration<Hang>
{
    public void Configure(EntityTypeBuilder<Hang> builder)
    {
        builder.HasKey(p => p.ID);
        builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
    }
}