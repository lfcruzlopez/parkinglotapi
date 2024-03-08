using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;

public  class Vehicle
{
    [Key]
    public Guid VehicleId { get; set; }

    [Required] [MaxLength(50)] public string? Model { get; set; }

    [Required] public int Year { get; set; }
    
    [Required] [MaxLength(50)] public string LicensePlate { get; set; }
    
    public int VehicleType { get; set; }

    public int Size { get; set; }

    public int VehicleNumber { get; set; }

    [ForeignKey("UserId")]
    public Guid UserId { get; set; } 
}