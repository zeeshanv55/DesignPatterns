namespace DesignPatterns.Decorator.CarDecorators
{
    class MattePaint : CarDecorator
    {
        public MattePaint(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return this.Car.GetCost() + 300;
        }

        public override string GetDescription()
        {
            return $"{this.Car.GetDescription()}, Matte";
        }
    }
}
