using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IKhachHangRepository
    {
        KhachHang GetKhachHangById(Guid id);
        IEnumerable<KhachHang> GetAllKhachHangs();
        void AddKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(Guid id);
    }
}
