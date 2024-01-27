using System.ComponentModel.DataAnnotations;

namespace ParkingLotApi.Data;

public class Manager
{
    [Key] public Guid ManagerId { get; set; }

    [Required] [MaxLength(50)] public string Username { get; set; }

    [Required] public string Password { get; set; }

    [Required] [MaxLength(100)] public string Email { get; set; }

    [MaxLength(50)] public string FirstName { get; set; }

    [MaxLength(50)] public string LastName { get; set; }

    [MaxLength(200)] public string Address { get; set; }
    
    [MaxLength(50)] public string Country { get; set; }

    [MaxLength(50)] public string City { get; set; }

    [MaxLength(50)] public string State { get; set; }

    [MaxLength(20)] public string ZipCode { get; set; }
    
    [MaxLength(15)] public string Phone { get; set; } // New Phone property

    public ICollection<ParkingLot> ParkingLots { get; set; }
}