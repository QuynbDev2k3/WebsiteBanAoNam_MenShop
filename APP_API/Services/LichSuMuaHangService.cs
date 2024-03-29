﻿using APP_DATA.Context;

using AppData.Serviece.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Serviece.Implements
{
    public class LichSuMuaHangService<T> : ILichSuMuaHangService<T> where T : class
    {
        public MyDbContext _dbContext;
        public DbSet<T> _dbSet;
        public LichSuMuaHangService(MyDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            this._dbSet = dbSet;
        }
        public bool AddItem(T item)
        {
            try
            {
                _dbSet.Add(item);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditItem(T item)
        {
            try
            {
                _dbSet.Update(item);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool RemoveItem(T item)
        {
            try
            {
                _dbSet.Remove(item);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
