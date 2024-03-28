<<<<<<< HEAD
﻿using APP_VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd

namespace APP_VIEW.Areas.Admin.Controllers
{
    [Area("Admin")]
<<<<<<< HEAD

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
=======
    public class HomeController : Controller
    {
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< HEAD
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
=======
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
    }
}
