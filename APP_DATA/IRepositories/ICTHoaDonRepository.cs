using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface ICTHoaDonRepository
    {
        CTHoaDon GetById(Guid id);
        List<CTHoaDon> GetAll();
        bool Add(CTHoaDon ctHoaDon);
        bool Update(CTHoaDon ctHoaDon);
        bool Delete(CTHoaDon ctHoaDon);
    }
}
