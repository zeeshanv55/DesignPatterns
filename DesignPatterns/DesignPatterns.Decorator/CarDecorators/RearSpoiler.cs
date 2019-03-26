namespace DesignPatterns.Decorator.CarDecorators
{
    class RearSpoiler : CarDecorator
    {
        public RearSpoiler(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return this.Car.GetCost() + 700;
        }

        public override string GetDescription()
        {
            return $"{this.Car.GetDescription()}, Rear Spoiler";
        }
    }
}
