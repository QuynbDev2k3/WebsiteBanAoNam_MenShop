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
    public class AnhConfiguration : IEntityTypeConfiguration<Anh>
    {
        public void Configure(EntityTypeBuilder<Anh> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.LinkAnh).IsRequired();
            builder.Property(r => r.TrangThai).IsRequired();
            builder.HasOne(r => r.CTSanPhams).WithMany(r => r.Anhs).HasForeignKey(r => r.IdCtSanPham);
        }
    }
}
