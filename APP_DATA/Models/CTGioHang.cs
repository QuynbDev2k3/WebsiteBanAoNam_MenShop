﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class CTGioHang
    {
        public Guid Id { get; set; }   
        public int TongTien { get; set; }
        public int SoLuong { get; set; }
        public GioHang? GioHang { get; set; }
        public CTSanPham? CTSanPhams { get; set; }
        public Guid? GioHangID { get; set; }
        public Guid? IdCTSanPham { get; set; }
        
    }
}
