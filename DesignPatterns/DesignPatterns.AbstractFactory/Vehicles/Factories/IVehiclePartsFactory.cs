namespace DesignPatterns.AbstractFactory.Vehicles.Factories
{
    using Engines;
    using Transmissions;

    interface IVehiclePartsFactory
    {
        IEngine CreateEngine();

        ITransmission CreateTransmission();
    }
}
