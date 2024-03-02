using APP_DATA.Models;
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
        public DbSet<Anh> anhs { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<LichSuMuaHang> lichSuMuaHangs { get; set; }
        public DbSet<DoiTra> doiTras { get; set; }
        public DbSet<KichCo> KichCos { get; set; }
        public DbSet<CTGioHang> CTGioHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<Role> Roles { get; set; }
<<<<<<< HEAD
        public DbSet<ChatLieu> chatlieus { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        public DbSet<CTHoaDon> CtHoadons { get; set; }
        public DbSet<HoaDon> hoadons { get; set; }
=======
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<CTSanPham> CtSanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<LichSuTichDiem> LichSuTichDiems { get; set; }
        public DbSet<QuyDoiDiem> QuyDoiDiems { get; set; }
>>>>>>> ff3b4691c3ea30f76b3817ca47c2fde5dceb8968
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VANLOI\\SQLEXPRESS;Initial Catalog = MenShop; Integrated Security=True;Trust Server Certificate=True");
=======
              //  optionsBuilder.UseSqlServer("Server=QUY\\SQLEXPRESS;Database=MenShop;Trusted_Connection=True;TrustServerCertificate=True");
>>>>>>> ff3b4691c3ea30f76b3817ca47c2fde5dceb8968
            }
        }
    }

}
