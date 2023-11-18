using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clients.Models.Domain;

[Table("Clients")]
public class Client
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    [StringLength(15, MinimumLength = 7)]
    public string Phone { get; set; }

    [EmailAddress]
    [StringLength(100, MinimumLength = 10)]
    public string Email { get; set; }

    public int AddressId { get; set; }
        
}
