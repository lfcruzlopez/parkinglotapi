using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;

public class Reservation {
    public Guid ReservationId { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    [ForeignKey("VehicleId")]
    public Guid VehicleId {get;set;}
    
    [ForeignKey("UserId")]
    public Guid UserId { get; set; }

    [ForeignKey("SpotId")]
    public Guid SpotId {get;set;}
    
    
    
}