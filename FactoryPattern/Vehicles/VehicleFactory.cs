namespace FactoryPattern.Vehicles
{
    public enum VehicleType
    {
        Car,
        Bike
    }

    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(VehicleType type)
        {
            return type switch
            {
                VehicleType.Car => new Car(),
                VehicleType .Bike=> new Bike(),
                _ => throw new ArgumentException("Invalid type"),
            };
        }
    }
}
