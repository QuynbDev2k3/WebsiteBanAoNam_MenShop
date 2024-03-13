using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Voucher
    {
        public Guid Id {  get; set; }
        public string Ten {  get; set; }
        public string DieuKien {  get; set; }
        public string GiaTri {  get; set; }
        public DateTime NgayApDung {  get; set; }
        public DateTime NgayHetHan {  get; set; }
        public int SoLuong {  get; set; }
        public string MoTa {  get; set; }
        public bool trangthai {  get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
        public virtual ICollection<HoaDon>? HoaDons { get; set; }


    }
}
