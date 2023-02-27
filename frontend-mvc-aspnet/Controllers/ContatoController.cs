using frontend_mvc_aspnet.Context;
using frontend_mvc_aspnet.Models;
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

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Contato contato)
    {
        if(ModelState.IsValid)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
        return View(contato);
    }

    public IActionResult Editar(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato is not null)
        {
            return View(contato);                       
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Editar(Contato contato)
    {
        var contatoAEditar = _context.Contatos.Find(contato.Id);

        contatoAEditar.Nome = contato.Nome;
        contatoAEditar.Telefone = contato.Telefone;
        contatoAEditar.Ativo = contato.Ativo;

        _context.Contatos.Update(contatoAEditar);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Detalhes(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato is not null)
        {
            return View(contato);
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Deletar(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato is not null)
        {
            return View(contato);
        }

        return RedirectToAction(nameof(Index));
    }
}
