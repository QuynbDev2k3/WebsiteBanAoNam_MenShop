using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class MauSac
    {
        public Guid Id { get; set; }
        public string TenMauSac { get; set; }

        public bool TrangThai { get; set; }

        public string Ma { get; set; }
        public virtual ICollection<CTSanPham>? cTSanPhams { get; set; }
    }
}
