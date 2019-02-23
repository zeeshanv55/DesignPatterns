namespace DesignPatterns.Strategy.Vehicles
{
    using Transmission;

    abstract class Vehicle : IVehicle
    {
        public ITransmission Transmission;

        public string Name { get; set; }

        public abstract string Move();

        public abstract string Turn();

        public string ShiftUp()
        {
            return this.Transmission.ShiftUp();
        }

        public string ShiftDown()
        {
            return this.Transmission.ShiftDown();
        }

        public void SetTransmissionType(ITransmission transmission)
        {
            this.Transmission = transmission;
        }
    }
}
