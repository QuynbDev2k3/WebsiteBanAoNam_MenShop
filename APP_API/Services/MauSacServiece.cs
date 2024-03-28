<<<<<<< HEAD
﻿using APP_API.IServices;
=======
﻿
using APP_API.IServices;
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
using APP_DATA.Context;
using APP_DATA.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_API.Services
{
    public class MauSacServiece : IMauSacServiece
    {
        private readonly MyDbContext _context;
        public MauSacServiece()
        {
            _context = new MyDbContext();
        }

        public bool Add(MauSac p)
        {
            try
            {
                MauSac mauSac = new MauSac()
                {
                    Id = Guid.NewGuid(),
                    TenMauSac = p.TenMauSac,
                    TrangThai = true,
                    Ma = p.Ma,
                };
                _context.Add(mauSac);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Del(Guid id)
        {
            try
            {
                MauSac mauSac = _context.mauSacs.FirstOrDefault(c => c.Id == id);
                if (mauSac != null)
                {
                    mauSac.TrangThai = true;
                };
                _context.mauSacs.Update(mauSac);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Guid id, MauSac p)
        {
            try
            {
                MauSac mauSac = _context.mauSacs.FirstOrDefault(c => c.Id == id);
                if (mauSac != null)
                {
                    mauSac.TenMauSac = p.TenMauSac;
                    mauSac.TrangThai = p.TrangThai;
                    mauSac.Ma = p.Ma;
                };
                _context.mauSacs.Update(mauSac);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

<<<<<<< HEAD
       
=======
        public bool Edit(Guid id, Anh p)
        {
            throw new NotImplementedException();
        }

>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        public List<MauSac> GetAll()
        {
            return _context.mauSacs.ToList();
        }
    }
}