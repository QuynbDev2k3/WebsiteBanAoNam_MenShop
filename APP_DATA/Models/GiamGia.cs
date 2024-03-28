using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class GiamGia
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public float GiaTri { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public bool trangThai { get; set; }
        public virtual ICollection<CTSanPham>? CTSanPhams { get; set; }
    }
}
