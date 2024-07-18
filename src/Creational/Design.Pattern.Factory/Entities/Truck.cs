using Design.Pattern.Factory.Interfaces;

namespace Design.Pattern.Factory.Entities
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck...");
        }
    }
}
