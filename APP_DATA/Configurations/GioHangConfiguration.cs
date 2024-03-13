using APP_DATA.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Configurations
{
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.IdGioHang).IsRequired();
            builder.Property(g => g.NgayTao);
            builder.HasOne(g => g.KhachHang).WithOne(g => g.GioHang).HasForeignKey<KhachHang>(p => p.Id);
        }
    }
}
