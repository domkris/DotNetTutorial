namespace FactoryPattern.Vehicles
{
    internal class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a bike.");
            Console.WriteLine("");
        }
    }
}
