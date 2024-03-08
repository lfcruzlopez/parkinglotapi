using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLotApi.Data;

public class SpotReservation
{
    [Key,Column(Order = 0)]
    public Guid SpotId { get; set; }
    public Spot Spot { get; set; }
    [Key,Column(Order = 1)]
    public Guid ReservationId { get; set; }
    public Reservation Reservation { get; set; }
}