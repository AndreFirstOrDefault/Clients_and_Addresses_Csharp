using Clients.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clients.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {        
    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<Address> Addresses { get; set; }
}
