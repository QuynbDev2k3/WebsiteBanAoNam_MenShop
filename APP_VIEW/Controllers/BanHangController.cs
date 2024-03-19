using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers
{
    public class BanHangController : Controller
    {
        public IActionResult TaiQuay()
        {
            return View();
        }
    }
}
