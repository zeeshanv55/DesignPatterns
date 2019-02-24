namespace DesignPatterns.AbstractFactory.Vehicles
{
    using Factories;

    class Motorcycle : Vehicle
    {
        public Motorcycle(IVehiclePartsFactory vehiclePartsFactory)
        {
            this.vehiclePartsFactory = vehiclePartsFactory;
            this.BuildVehicle();
        }

        public override string Move()
        {
            return $"Riding at {this.MaxSpeed} kmph";
        }

        public override string Turn()
        {
            return "Leaning";
        }
    }
}
