using System;
using System.Collections.Generic;

namespace ParkingLotApi.Migrations;

public partial class Spot
{
    public Guid SpotId { get; set; }

    public bool IsAvailable { get; set; }

    public int SpotSize { get; set; }

    public int SpotNumber { get; set; }

    public int SpotLevel { get; set; }

    public string Location { get; set; } = null!;

    public Guid ParkingLotId { get; set; }

    public Guid? VehicleId { get; set; }

    public Guid? UserId { get; set; }

    public virtual ParkingLot ParkingLot { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
