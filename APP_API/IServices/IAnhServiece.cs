using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IAnhServiece
    {
        Task<IEnumerable<Anh>> GetAll();
        Task<Anh> GetById(Guid id);
        Task Add(string linkanh, bool trangthai);
        Task Edit(Guid id, string linkanh, bool trangthai);
        Task Delete(Guid id);
    }
}

//using APP_DATA.Models;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bill.Serviece.Interfaces
//{
//    public interface IAnhServiece
//    {
//        public bool Add(Anh p);
//        public List<Anh> GetAll();
//        public bool Del(Guid id);
//        public bool Edit(Guid id, Anh p);
//    }
//}
