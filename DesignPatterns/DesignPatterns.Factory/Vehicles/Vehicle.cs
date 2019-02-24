namespace DesignPatterns.Factory.Vehicles
{
    abstract class Vehicle : IVehicle
    {
        public long MaxSpeed { get; set; }

        public string Name { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string name)
        {
            this.Name = name;
        }

        public abstract string Move();
    }
}
