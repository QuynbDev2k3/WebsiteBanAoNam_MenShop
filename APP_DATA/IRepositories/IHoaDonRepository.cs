using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IHoaDonRepository
    {
        HoaDon GetById(Guid id);
        List<HoaDon> GetAll();
        bool Add(HoaDon hoadon);
        bool Update(HoaDon hoadon);
        bool Delete(HoaDon hoadon);
    }
}
