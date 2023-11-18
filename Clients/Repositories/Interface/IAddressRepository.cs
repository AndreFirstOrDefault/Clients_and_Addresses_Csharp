using Clients.Models.Domain;

namespace Clients.Repositories.Interface;

public interface IAddressRepository
{
    Task<Address> CreateAsync(Address address);
}
