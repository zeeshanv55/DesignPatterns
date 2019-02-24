namespace DesignPatterns.AbstractFactory.AbstractFactories
{
    using Vehicles;

    abstract class VehicleAbstractFactoryBase : IVehicleAbstractFactory
    {
        protected abstract IVehicle CreateVehicle(VehicleType vehicleType);

        public IVehicle GetVehicle(VehicleType vehicleType)
        {
            IVehicle vehicle = CreateVehicle(vehicleType);
            return vehicle;
        }
    }
}