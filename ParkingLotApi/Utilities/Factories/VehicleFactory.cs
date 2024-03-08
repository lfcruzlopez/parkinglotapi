using ParkingLotApi.Abstraction;
using ParkingLotApi.Enum;
using ParkingLotApi.Models;

namespace ParkingLotApi.Utilities.Factories;

// Vehicle Factory
public class VehicleFactory
{
    public static VehicleBase CreateVehicle(VehicleType type, Size size)
    {
        VehicleBase vehicleBase = type switch
        {
            VehicleType.Car => new Car(),
            VehicleType.Truck => new Truck(),
            VehicleType.Motorcycle => new Motorcycle(),
            VehicleType.Suv => new Suv(),
            VehicleType.Bicycle => new Bicycle(),
            VehicleType.RV => // New Case
                new RV(),
            _ => throw new NotSupportedException("This vehicle type is not supported")
        };

        vehicleBase.Size = size;
        return vehicleBase;
    }
}