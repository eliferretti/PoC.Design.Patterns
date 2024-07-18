using Design.Pattern.Factory.Entities;
using Design.Pattern.Factory.Interfaces;

namespace Design.Pattern.Factory.Factories
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "truck" => new Truck(),
                _ => throw new ArgumentException("Invalid vehicle type")
            };
        }
    }
}
