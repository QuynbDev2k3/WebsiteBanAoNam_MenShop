using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class CTHoaDon
    {
        public Guid Id { get; set; }
        //FK
        public Guid IdHoaDon { get; set; }
        public Guid IdCTSP { get; set; }
        public int dongia { get; set; }  
        public int soluong { get; set; }
        public bool trangthai { get; set; }
        public virtual HoaDon? HoaDon { get; set; }

    }
}
