using Clients.Data;
using Clients.Models.Domain;
using Clients.Models.DTO;
using Clients.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    
    private readonly IClientRepository clientRepository;

    public ClientsController(IClientRepository clientRepository)
    {
        this.clientRepository = clientRepository;
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient(CreateClientRequestDto request)
    {
        // Map DTO to Domain Model
        var client = new Client
        {
            Name = request.Name,
            Phone = request.Phone,
            Email = request.Email,
            AddressId = request.AddressId
        };

        await clientRepository.CreateAsync(client);

        // Domain model to DTO
        var response = new ClientDto
        {
            Id = client.Id,
            Name = client.Name,
            Phone = client.Phone,
            Email = client.Email
        };

        
        return Ok(response);
    }
}

