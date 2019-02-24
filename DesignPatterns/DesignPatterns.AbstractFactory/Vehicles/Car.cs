namespace DesignPatterns.AbstractFactory.Vehicles
{
    using Factories;

    class Car : Vehicle
    {
        public Car(IVehiclePartsFactory vehiclePartsFactory)
        {
            this.vehiclePartsFactory = vehiclePartsFactory;
            this.BuildVehicle();
        }

        public override string Move()
        {
            return $"Driving at {this.MaxSpeed} kmph";
        }

        public override string Turn()
        {
            return $"Steering";
        }
    }
}
