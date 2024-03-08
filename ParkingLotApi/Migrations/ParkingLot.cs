using System;
using System.Collections.Generic;

namespace ParkingLotApi.Migrations;

public partial class ParkingLot
{
    public Guid ParkingLotId { get; set; }
    
    public string LocationName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string ParkingType { get; set; } = null!;

    public Guid ManagerId { get; set; }

    public virtual Manager Manager { get; set; } = null!;

    public virtual ICollection<Spot> Spots { get; set; } = new List<Spot>();
}
