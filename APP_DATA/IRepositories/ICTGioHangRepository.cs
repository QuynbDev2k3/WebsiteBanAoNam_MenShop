using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface ICTGioHangRepository
    {
        CTGioHang GetCTGioHangById(Guid id);
        IEnumerable<CTGioHang> GetAllCTGioHangs();
        void AddCTGioHang(CTGioHang ctGioHang);
        void UpdateCTGioHang(CTGioHang ctGioHang);
        void DeleteCTGioHang(Guid id);

    }
}
