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
    public class CTGioHangConfiguration : IEntityTypeConfiguration<CTGioHang>
    {
        public void Configure(EntityTypeBuilder<CTGioHang> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TongTien);
            builder.Property(c => c.SoLuong);
            builder.HasOne(c => c.GioHang).WithMany(c => c.cTGioHangs).HasForeignKey(c => c.GioHangID);
            builder.HasOne(c => c.CTSanPhams).WithMany(c => c.CTGioHang).HasForeignKey(c => c.IdCTSanPham);
        }
    }
}
    