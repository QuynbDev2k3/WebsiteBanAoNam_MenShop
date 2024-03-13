using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class LichSuTichDiem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdQuyDoiDiem { get; set; }
        public Guid? IdHoaDon {  get; set; }
        public float Diem {  get; set; }
        public bool TrangThai {  get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual QuyDoiDiem? QuyDoiDiem { get; set; }
        public virtual HoaDon? HoaDon { get; set; }
    }
}
