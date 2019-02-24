namespace DesignPatterns.Factory.Vehicles
{
    class Truck : Vehicle
    {
        public Truck()
        {

        }

        public Truck(string name) : base(name)
        {

        }

        public override string Move()
        {
            return $"Hauling at {this.MaxSpeed} kmph";
        }
    }
}
