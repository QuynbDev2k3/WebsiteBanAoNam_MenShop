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
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Ten).IsRequired();
            builder.Property(r => r.DieuKien).IsRequired();
            builder.Property(r => r.GiaTri).IsRequired();
            builder.Property(r => r.NgayApDung).IsRequired();
            builder.Property(r => r.NgayHetHan).IsRequired();
            builder.Property(r => r.SoLuong).IsRequired();
            builder.Property(r => r.MoTa).IsRequired();
            builder.Property(r => r.trangthai).IsRequired();

        }
    }
    
    
}
