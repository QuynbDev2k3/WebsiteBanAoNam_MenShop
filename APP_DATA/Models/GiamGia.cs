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
        public string BinhLuan { get; set; }
        public int Sao {  get; set; }
        public DateTime NgayDanhGia { get; set; }
        public bool trangThai { get; set; }
    }
}
