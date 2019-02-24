namespace DesignPatterns.Factory.Vehicles
{
    class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(string name) : base(name)
        {

        }

        public override string Move()
        {
            return $"Driving at {this.MaxSpeed} kmph";
        }
    }
}
