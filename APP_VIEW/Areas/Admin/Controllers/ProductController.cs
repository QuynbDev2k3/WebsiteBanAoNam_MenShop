using APP_API.Services;
using APP_DATA.Context;
using APP_VIEW.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_VIEW.Areas.Admin.Controllers
{
    
    public class ProductController : Controller
    {
<<<<<<< HEAD
        //private readonly DbContext _context;
        //private readonly ILogger<ProductController> _logger;

        //public ProductController(ILogger<ProductController> logger)
        //{
        //    _logger = logger;
        //}

=======
       
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
           
        }
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
