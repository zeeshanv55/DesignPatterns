namespace DesignPatterns.AbstractFactory.Vehicles.Factories
{
    using Engines;
    using Transmissions;

    class TruckPartsFactory : IVehiclePartsFactory
    {
        public IEngine CreateEngine()
        {
            return new DieselEngine();
        }

        public ITransmission CreateTransmission()
        {
            return new AutomaticTransmission();
        }
    }
}
