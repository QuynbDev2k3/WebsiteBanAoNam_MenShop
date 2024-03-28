using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
