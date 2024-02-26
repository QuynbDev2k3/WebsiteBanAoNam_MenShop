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
    public class KichCoConfiguration : IEntityTypeConfiguration<KichCo>
    {
        public void Configure(EntityTypeBuilder<KichCo> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Name).IsRequired();
            builder.Property(k => k.TrangThai);
            builder.Property(k => k.Ma);
        }
    }
}
