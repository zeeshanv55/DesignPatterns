namespace DesignPatterns.AbstractFactory.AbstractFactories
{
    using Vehicles;
    using Vehicles.Factories;

    class VehicleAbstractFactory : VehicleAbstractFactoryBase
    {
        protected override IVehicle CreateVehicle(VehicleType vehicleType)
        {
            IVehicle vehicle = null;
            switch (vehicleType)
            {
                case VehicleType.Car:
                    IVehiclePartsFactory carFactory = new CarPartsFactory();
                    vehicle = new Car(carFactory);
                    break;

                case VehicleType.Motorcycle:
                    IVehiclePartsFactory motorcycleFactory = new MotorcyclePartsFactory();
                    vehicle = new Motorcycle(motorcycleFactory);
                    break;

                case VehicleType.Truck:
                    IVehiclePartsFactory truckFactory = new TruckPartsFactory();
                    vehicle = new Truck(truckFactory);
                    break;
            }

            return vehicle;
        }
    }
}
