namespace DesignPatterns.AbstractFactory.Vehicles
{
    using Factories;

    class Truck : Vehicle
    {
        public Truck(IVehiclePartsFactory vehiclePartsFactory)
        {
            this.vehiclePartsFactory = vehiclePartsFactory;
            this.BuildVehicle();
        }

        public override string Move()
        {
            return $"Hauling at {this.MaxSpeed}";
        }

        public override string Turn()
        {
            return $"Turning";
        }
    }
}
