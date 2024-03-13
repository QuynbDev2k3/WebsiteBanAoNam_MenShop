using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace APP_DATA.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        //foreign key
        public Guid IdCTHoaDon { get; set; }
        public Guid IdVoucher { get; set; }   
        public Guid IdNhanVien { get; set; }
        public Guid IdKhachHang { get; set; }
        public int MaHD { get; set; }
        public int TienShip { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenNgNhan { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string PTThanhToan { get; set; }
        public int TongTien { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<CTHoaDon>? CTHoaDons { get; set; }
        public virtual ICollection<Voucher>? Vouchers { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual DoiTra? DoiTra { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual LichSuMuaHang? LichSuMuaHang { get; set; }
        public virtual LichSuTichDiem? LichSuTichDiem { get; set; }
    }
}
