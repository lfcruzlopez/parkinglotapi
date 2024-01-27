using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;

public class Spot
{
    [Key] public Guid SpotId { get; set; }

    public bool IsAvailable { get; set; }

    public int SpotSize { get; set; }
    
    public int SpotNumber { get; set; }
    
    public int SpotLevel { get; set; }
    
    public string Location { get; set; }
    
    [ForeignKey("ParkingLotId")]
    public Guid ParkingLotId { get; set; }  
    
    [ForeignKey("Vehicle")]
    public Guid? VehicleId { get; set; } 
    
    [ForeignKey("UserId")]
    public Guid? UserId { get; set; } 

}