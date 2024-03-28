﻿using APP_DATA.Models;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.Serviece.Interfaces
{
    public interface IMauSacServiece
    {
        public bool Add(MauSac p);
        public List<MauSac> GetAll();
        public bool Delete(Guid id); 
        public bool Edit(Guid id, MauSac p);
    }
}
