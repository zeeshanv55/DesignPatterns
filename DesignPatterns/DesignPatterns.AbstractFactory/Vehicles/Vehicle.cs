namespace DesignPatterns.AbstractFactory.Vehicles
{
    using Engines;
    using Factories;
    using Transmissions;

    abstract class Vehicle : IVehicle
    {
        protected IVehiclePartsFactory vehiclePartsFactory;

        public IEngine Engine { get; set; }

        public ITransmission Transmission { get; set; }

        public string Name { get; set; }

        public long MaxSpeed { get; set; }

        protected void BuildVehicle()
        {
            this.Engine = this.vehiclePartsFactory.CreateEngine();
            this.Transmission = this.vehiclePartsFactory.CreateTransmission();
        }

        public void SetTransmission(ITransmission transmission)
        {
            this.Transmission = transmission;
        }

        public void SetEngine(IEngine engine)
        {
            this.Engine = engine;
        }

        public string Start()
        {
            return this.Engine.Start();
        }

        public string Stop()
        {
            return this.Engine.Stop();
        }

        public string ShiftUp()
        {
            return this.Transmission.ShiftUp();
        }

        public string ShiftDown()
        {
            return this.Transmission.ShiftDown();
        }

        public abstract string Move();

        public abstract string Turn();
    }
}
