namespace FactoryPattern.Vehicles
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car.");
            Console.WriteLine("");
        }
    }
}
