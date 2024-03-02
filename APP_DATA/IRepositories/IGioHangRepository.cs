using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IGioHangRepository
    {
        GioHang GetGioHangById(Guid id);
        IEnumerable<GioHang> GetAllGioHangs();
        void AddGioHang(GioHang gioHang);
        void UpdateGioHang(GioHang gioHang);
        void DeleteGioHang(Guid id);
    }
}
