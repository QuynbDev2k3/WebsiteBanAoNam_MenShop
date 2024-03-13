using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public int Diem { get; set; }
        public bool TrangThai { get; set; }
        public string DiaChi { get; set; }
        public ICollection<LichSuMuaHang>? lichSuMuaHangs { get; set; }
        public virtual GioHang? GioHang { get; set; }
        public ICollection<HoaDon>? hoaDons { get; set; }
        public ICollection<LichSuTichDiem>? lichSuTichDiems { get; set; }
    }
}
