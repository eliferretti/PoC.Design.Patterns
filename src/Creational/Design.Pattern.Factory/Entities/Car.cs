using Design.Pattern.Factory.Interfaces;

namespace Design.Pattern.Factory.Entities
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}
