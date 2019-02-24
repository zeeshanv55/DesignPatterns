namespace DesignPatterns.AbstractFactory.Vehicles.Factories
{
    using Engines;
    using Transmissions;

    class MotorcyclePartsFactory : IVehiclePartsFactory
    {
        public IEngine CreateEngine()
        {
            return new PetrolEngine();
        }

        public ITransmission CreateTransmission()
        {
            return new ManualTransmission();
        }
    }
}
