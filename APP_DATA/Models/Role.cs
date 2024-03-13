﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<NhanVien>? NhanViens { get; set; }
    }
}
