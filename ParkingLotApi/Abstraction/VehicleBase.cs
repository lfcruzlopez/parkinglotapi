using ParkingLotApi.Enum;

namespace ParkingLotApi.Abstraction;

public abstract class VehicleBase
{
    public Guid VehicleId { get; private set; } = Guid.NewGuid();
    public Size Size { get; set; }
    public VehicleType Type { get; set; }
}