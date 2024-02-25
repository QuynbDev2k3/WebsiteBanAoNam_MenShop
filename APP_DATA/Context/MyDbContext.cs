using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=WINDOWS10\\SQLEXPRESS;Database=TestNew;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
    }

}
