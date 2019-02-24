namespace DesignPatterns.Factory.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public Motorcycle(string name) : base(name)
        {

        }

        public override string Move()
        {
            return $"Riding at {this.MaxSpeed} kmph";
        }
    }
}
