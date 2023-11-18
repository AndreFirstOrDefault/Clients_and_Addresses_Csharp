using Clients.Data;
using Clients.Models.Domain;
using Clients.Repositories.Interface;

namespace Clients.Repositories.Implementation;

public class AddressRepository : IAddressRepository
{
    private readonly AppDbContext dbContext;

    public AddressRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Address> CreateAsync(Address address)
    {
        await dbContext.Addresses.AddAsync(address);
        await dbContext.SaveChangesAsync();

        return address;
    }
}
