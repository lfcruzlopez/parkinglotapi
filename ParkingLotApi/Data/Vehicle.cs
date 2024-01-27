using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;

public abstract class Vehicle
{
    [Key]
    public Guid VehicleId { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }
    
    public string LicensePlate { get; set; }
    
    public int VehicleType { get; set; }

    public int Size { get; set; }

    [ForeignKey("UserId")]
    public Guid UserId { get; set; } 
}