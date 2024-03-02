using APP_DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.IRepositories
{
    public interface IVoucherRepository 
    {
        Voucher GetById(Guid id);
        List<Voucher> GetAll();
        bool Add(Voucher voucher);
        bool Update(Voucher voucher);
        bool Delete(Voucher voucher);
    }
}
