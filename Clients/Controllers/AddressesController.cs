using Clients.Data;
using Clients.Models.Domain;
using Clients.Models.DTO;
using Clients.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressesController : ControllerBase
{
    private readonly AppDbContext dbContext;

    private readonly IAddressRepository addressRepository;

    public AddressesController(IAddressRepository addressRepository)
    {
        this.addressRepository = addressRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAddress(CreateAddressRequestDto request)
    {
        // Map DTO to Domain Model
        var address = new Address
        {
            Street = request.Street,
            Number = request.Number,
            PostalCode = request.PostalCode,
            City = request.City,
            State = request.State,
            Country = request.Country,
            Neighborhood = request.Neighborhood
        };

        await addressRepository.CreateAsync(address);

        // Domain model to DTO
        var response = new AddressDto
        {
            Id = address.Id,
            Street = address.Street,
            Number = address.Number,
            PostalCode = address.PostalCode,
            City = address.City, 
            State = address.State,
            Country = address.Country,
            Neighborhood = address.Neighborhood
        };
                
        return Ok(response);
    }
}
