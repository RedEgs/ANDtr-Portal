using Microsoft.AspNetCore.Mvc;

namespace ANDtr.Controllers;

public class HomeController : Controller
{
    // GET /  or  /Home/Index  ->  renders Views/Home/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Portal()
    {
        return View();
    }
}
