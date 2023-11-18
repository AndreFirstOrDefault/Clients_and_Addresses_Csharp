using Clients.Data;
using Clients.Models.Domain;
using Clients.Repositories.Interface;

namespace Clients.Repositories.Implementation;

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext dbContext;

    public ClientRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Client> CreateAsync(Client client)
    {
        await dbContext.Clients.AddAsync(client);
        await dbContext.SaveChangesAsync();

        return client;
    }
}
