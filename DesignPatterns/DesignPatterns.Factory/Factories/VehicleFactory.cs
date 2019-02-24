namespace DesignPatterns.Factory.Factories
{
    using Vehicles;

    static class VehicleFactory
    {
        public static IVehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car();

                case VehicleType.Truck:
                    return new Truck();

                case VehicleType.Motorcycle:
                    return new Motorcycle();

                case VehicleType.Boat:
                    return new Boat();

                default:
                    return null;
            }
        }
    }
}
