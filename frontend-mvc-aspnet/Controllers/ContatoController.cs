using Microsoft.AspNetCore.Mvc;

namespace frontend_mvc_aspnet.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
