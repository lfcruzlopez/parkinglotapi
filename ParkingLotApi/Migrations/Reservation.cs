using System;
using System.Collections.Generic;

namespace ParkingLotApi.Migrations;

public partial class Reservation
{
    public Guid ReservationId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public Guid VehicleId { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Spot> Spots { get; set; } = new List<Spot>();
}
