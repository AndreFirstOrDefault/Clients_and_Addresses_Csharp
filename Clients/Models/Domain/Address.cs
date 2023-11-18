using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clients.Models.Domain;

[Table("Addresses")]
public class Address
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100,MinimumLength = 3)]
    public string Street { get; set; }

    [Required]
    [StringLength(10,MinimumLength = 1)]
    public string Number { get; set; }

    [StringLength(10,MinimumLength = 8)]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(50,MinimumLength = 3)]
    public string Neighborhood { get; set; }

    [Required]
    [StringLength(50,MinimumLength = 3)]
    public string City { get; set; }

    [Required]
    [StringLength (25,MinimumLength = 2)]
    public string State { get; set; }

    [Required]
    [StringLength(25,MinimumLength = 3)]
    public string Country { get; set; }
        
}
