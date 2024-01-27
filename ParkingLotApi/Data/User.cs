using System.ComponentModel.DataAnnotations;
using ParkingLotApi.Enum;

namespace ParkingLotApi.Data;

public class User
{
    [Key] public Guid UserId { get; set; }

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
    
    public ICollection<Reservation> Reservations { get; set; }
    
    public ICollection<VehicleType> Vehicle { get; set; }

}
 