using Clients.Models.Domain;

namespace Clients.Models.DTO;

public class CreateClientRequestDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public int AddressId { get; set; }

    //public Address address { get; set; }

}
