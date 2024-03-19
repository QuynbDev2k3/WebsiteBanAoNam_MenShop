using Microsoft.AspNetCore.Mvc;

namespace APP_VIEW.Controllers;

public class BanHangController : Controller
{
    private readonly ILogger<BanHangController> _logger;

    public BanHangController(ILogger<BanHangController> logger)
    {
        _logger = logger;
    }
    // GET
    public IActionResult TaiQuay()
    {
        return View();
    }
}