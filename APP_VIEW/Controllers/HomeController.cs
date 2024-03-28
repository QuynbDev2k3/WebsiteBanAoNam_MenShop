using APP_DATA.Context;
using APP_VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Internal;
using System.Diagnostics;


namespace APP_VIEW.Controllers
{

    public class HomeController : Controller
    {
        MyDbContext _context = new MyDbContext();
       

        public ActionResult Index()
            {
            var lstProduct = _context.SanPhams.ToList();
            var lstdanhmuc = _context.DanhMucSanPhams.ToList();
            Sanpham_Theloai objsp_theloai = new Sanpham_Theloai();
            objsp_theloai.ListDanhMuc = lstdanhmuc;
            objsp_theloai.ListSanPham = lstProduct ;
            return View(objsp_theloai);
            }
       

       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
