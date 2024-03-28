using APP_DATA.Context;
using APP_DATA.Models;
using APP_VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers
{
    public class DetailController : Controller
    {
        MyDbContext _context = new MyDbContext();
        //SanPham _sanpham = new SanPham();

        public ActionResult index(Guid id)
        {
            //lấy thông tin sản phẩm theo id truyền vào
            var objsp = _context.SanPhams.FirstOrDefault(p => p.ID == id);
            //lấy danh sách danh mục
            var listdm = _context.DanhMucSanPhams.ToList();
            //lấy danh sách sản phẩm liên quan trong iddanhmuc được lấy từ biến objproduct
            var listsp = _context.SanPhams.Where(p => p.IDDanhMucSanPham == objsp.IDDanhMucSanPham).ToList();

            CTSanPhamViewModel objctspviewmodel = new CTSanPhamViewModel();
            objctspviewmodel.objSanPham = objsp;
            objctspviewmodel.listDanhmuc = listdm;
            objctspviewmodel.Listsanpham = listsp;
            return View(objctspviewmodel);

        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}
