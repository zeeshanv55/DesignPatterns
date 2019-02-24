namespace DesignPatterns.AbstractFactory.AbstractFactories
{
    using Vehicles;

    interface IVehicleAbstractFactory
    {
        IVehicle GetVehicle(VehicleType vehicleType);
    }
}
