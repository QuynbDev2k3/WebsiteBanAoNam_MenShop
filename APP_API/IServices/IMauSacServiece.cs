using APP_DATA.Models;

namespace APP_API.IServices
{
    public interface IMauSacServiece
    {
        public List<MauSac> GetAll();
<<<<<<< HEAD
        public bool Delete(Guid id); 
=======
        public bool Add(MauSac p);
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        public bool Edit(Guid id, MauSac p);
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
//    public interface IMauSacServiece
//    {
//        public bool Add(MauSac p);
//        public List<MauSac> GetAll();
//        public bool Del(Guid id);
//        public bool Edit(Guid id, MauSac p);
//    }
//}
