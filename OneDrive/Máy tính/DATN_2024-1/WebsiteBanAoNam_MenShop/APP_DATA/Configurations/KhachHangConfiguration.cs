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
    internal class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Ten).IsRequired();
            builder.Property(k => k.GioiTinh);
            builder.Property(k => k.NgaySinh);
            builder.Property(k => k.SDT).IsRequired();
            builder.Property(k => k.MatKhau).IsRequired();
            builder.Property(k => k.Email).IsRequired();
            builder.Property(k => k.Diem);
            builder.Property(k => k.TrangThai);
            builder.Property(k => k.DiaChi);
        }
    }
}
