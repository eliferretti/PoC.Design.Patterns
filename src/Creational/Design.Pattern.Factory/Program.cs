using Design.Pattern.Factory.Factories;
using Design.Pattern.Factory.Interfaces;

IVehicle car = VehicleFactory.CreateVehicle("car");
car.Drive();  // Output: Driving a car...

IVehicle truck = VehicleFactory.CreateVehicle("truck");
truck.Drive();  // Output: Driving a truck...
