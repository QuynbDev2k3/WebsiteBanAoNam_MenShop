﻿using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
