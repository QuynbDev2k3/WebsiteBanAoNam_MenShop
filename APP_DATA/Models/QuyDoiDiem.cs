using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class QuyDoiDiem
    {
        public Guid Id { get; set; }
        public bool TrangThai { get; set; }
        public float TiLeTichDiem { get; set; }
        public virtual ICollection<LichSuTichDiem>? LichSuTichDiems { get; set; }
    }
}
