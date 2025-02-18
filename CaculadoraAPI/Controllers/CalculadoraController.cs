using Microsoft.AspNetCore.Mvc;

namespace CaculadoraAPI.Controllers;

public class CalculadoraController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}