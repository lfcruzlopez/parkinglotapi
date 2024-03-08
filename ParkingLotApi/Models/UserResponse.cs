using ParkingLotApi.Data;

namespace ParkingLotApi.Models;

public class UserModel
{
    public Guid UserId { get; set; }

    public string Username { get; set; }

    public int UserNumber { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Address { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string Phone { get; set; }

    public IEnumerable<Vehicle> Vehicles { get; set; }


}