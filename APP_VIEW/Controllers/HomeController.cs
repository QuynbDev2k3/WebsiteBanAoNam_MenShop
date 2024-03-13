using APP_DATA.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;

        public HomeController(MyDbContext context) {
            _context = context;
        }
        
        
    }
}
