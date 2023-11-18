using Clients.Models.Domain;

namespace Clients.Repositories.Interface;

public interface IClientRepository
{
    Task<Client> CreateAsync(Client client);
}
