using System;
using System.Collections.Generic;

namespace ParkingLotApi.Migrations;

public partial class Vehicle
{
    public Guid VehicleId { get; set; }

    public string? Model { get; set; }

    public int Year { get; set; }

    public string LicensePlate { get; set; } = null!;

    public int VehicleType { get; set; }

    public int Size { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
