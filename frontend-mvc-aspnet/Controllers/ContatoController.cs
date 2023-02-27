using frontend_mvc_aspnet.Context;
using Microsoft.AspNetCore.Mvc;

namespace frontend_mvc_aspnet.Controllers;

public class ContatoController : Controller
{
    private readonly AgendaContext _context;

    public ContatoController(AgendaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var contatos = _context.Contatos.ToList();
        return View(contatos);
    }
}
