using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class DoiTra
    {
        public Guid Guid { get; set; }
        public DateTime NgayDoiTra { get; set; }
        public string Lydo {  get; set; }
        public DateTime HanDoi { get; set; }
        public int status { get; set; } 
    }
}
