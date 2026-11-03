using ANDtr.Data;
using Microsoft.AspNetCore.Mvc;

namespace ANDtr.Controllers;

public class DatabaseController : Controller
{
    private readonly DatabaseContext _db;

    public DatabaseController(DatabaseContext db)
    {
        _db = db;
    }

    public IActionResult viewer()
    {
        var products = _db.Products.ToList();   // SELECT * FROM Products
        return View(products);                  // pass them to the view as the model
    }
    
    
}