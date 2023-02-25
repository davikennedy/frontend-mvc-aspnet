using frontend_mvc_aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace frontend_mvc_aspnet.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
    }

    public DbSet<Contato> Contatos { get; set; }
}
