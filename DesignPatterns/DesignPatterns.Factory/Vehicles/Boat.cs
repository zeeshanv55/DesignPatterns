namespace DesignPatterns.Factory.Vehicles
{
    class Boat : Vehicle
    {
        public Boat()
        {

        }

        public Boat(string name) : base(name)
        {

        }

        public override string Move()
        {
            return $"Floating at {this.MaxSpeed} kmph";
        }
    }
}
