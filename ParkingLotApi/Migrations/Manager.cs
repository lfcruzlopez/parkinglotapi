using System;
using System.Collections.Generic;

namespace ParkingLotApi.Migrations;

public partial class Manager
{
    public Guid ManagerId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<ParkingLot> ParkingLots { get; set; } = new List<ParkingLot>();
}
