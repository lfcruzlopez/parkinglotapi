namespace ParkingLotApi.Models;

public class ReservationRequest
{
    public string SpotId { get; set; }
        
    public string ParkingLotId { get; set; }
         
    public DateTime StartTime { get; set; }
         
    public DateTime EndTime { get; set; }
         
    public Guid VehicleId {get;set;}
         
    public Guid UserId { get; set; }
}