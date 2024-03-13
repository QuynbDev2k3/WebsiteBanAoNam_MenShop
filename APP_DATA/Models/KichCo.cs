using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class KichCo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool TrangThai { get; set; }
        public int Ma { get; set; }
        public ICollection<CTSanPham>? cTSanPhams { get; set; }
    }
}
