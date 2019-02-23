namespace DesignPatterns.Strategy.Vehicles
{ 
    using Transmission;

    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            this.Transmission = new ManualTransmission();
        }

        public override string Move()
        {
            return "Riding";
        }

        public override string Turn()
        {
            return "Leaning";
        }
    }
}
