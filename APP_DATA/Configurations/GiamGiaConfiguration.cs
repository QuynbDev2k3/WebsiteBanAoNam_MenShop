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
    internal class GiamGiaConfiguration : IEntityTypeConfiguration<GiamGia>
    {
        public void Configure(EntityTypeBuilder<GiamGia> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.GiaTri).HasColumnType("float").IsRequired();
            builder.Property(p => p.NgayApDung).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.NgayHetHan).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(p => p.trangThai).HasColumnType("int").IsRequired();

        }
    }
}
