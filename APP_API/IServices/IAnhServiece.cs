using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IAnhServiece
    {
        public List<Anh> GetAll();
        public bool Add(Anh p);
        public bool Edit(Guid id, Anh p);
        public bool Delete(Guid id);
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
