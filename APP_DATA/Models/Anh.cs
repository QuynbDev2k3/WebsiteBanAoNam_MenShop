using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Anh
    {
        public Guid Id { get; set; }
<<<<<<< HEAD
        public Guid IdCtSanPham { get; set; }
=======
        List<Anh> GetAll { get; set; }
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        public string LinkAnh { get; set; }
        public bool TrangThai { get; set; }
        public virtual CTSanPham? CTSanPhams { get; set; }
    }
}
