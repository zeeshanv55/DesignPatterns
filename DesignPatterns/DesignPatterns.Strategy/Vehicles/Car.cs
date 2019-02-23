namespace DesignPatterns.Strategy.Vehicles
{
    using Transmission;

    class Car : Vehicle
    {
        public Car()
        {
            this.Transmission = new AutomaticTransmission();
        }

        public override string Move()
        {
            return "Driving";
        }

        public override string Turn()
        {
            return "Steering";
        }
    }
}
