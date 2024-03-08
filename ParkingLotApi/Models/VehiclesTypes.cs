using ParkingLotApi.Abstraction;
using ParkingLotApi.Enum;

namespace ParkingLotApi.Models;

public class Car : VehicleBase
{
    public Car() : base()
    {
        Size = Size.Medium;
        Type = VehicleType.Car;
    }
}

public class Truck : VehicleBase
{
    public Truck() : base()
    {
        Size = Size.Large;
        Type = VehicleType.Truck;
    }
}

public class Motorcycle : VehicleBase
{
    public Motorcycle() : base()
    {
        Size = Size.Small;
        Type = VehicleType.Motorcycle;
    }
}

public class Suv : VehicleBase
{
    public Suv() : base()
    {
        Size = Size.Large;
        Type = VehicleType.Suv;
    }
}

public class Bicycle : VehicleBase
{
    public Bicycle() : base()
    {
        Size = Size.Small;
        Type = VehicleType.Bicycle;
    }
}

public class RV : VehicleBase // New Vehicle class
{
    public RV() : base()
    {
        Size = Size.Large;
        Type = VehicleType.RV;
    }
}
