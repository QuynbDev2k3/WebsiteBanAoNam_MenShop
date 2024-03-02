using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IKichCoRepository
    {
        KichCo GetKichCoById(Guid id);
        IEnumerable<KichCo> GetAllKichCos();
        void AddKichCo(KichCo kichCo);
        void UpdateKichCo(KichCo kichCo);
        void DeleteKichCo(Guid id);
    }
}
