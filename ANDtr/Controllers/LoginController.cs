using Microsoft.AspNetCore.Mvc;

namespace ANDtr.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult employeeLogin()
    {
        return View();
    }

    public IActionResult customerLogin()
    {
        return View();
    }
}