using System.Collections;
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
    
    public int ReservationNumber { get; set; }
    public ICollection<SpotReservation> SpotReservations { get; set; }
    
    
}