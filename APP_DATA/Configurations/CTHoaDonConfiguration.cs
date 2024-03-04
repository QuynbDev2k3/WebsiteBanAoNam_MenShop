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
    public class CTHoaDonConfiguration : IEntityTypeConfiguration<CTHoaDon>
    {
        public void Configure(EntityTypeBuilder<CTHoaDon> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.dongia).IsRequired();
            builder.Property(r => r.soluong).IsRequired();
            builder.Property(r => r.trangthai).IsRequired();
            

        }
    }
}
