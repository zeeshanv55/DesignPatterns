namespace DesignPatterns.Decorator.CarDecorators
{
    class ClearCoat : CarDecorator
    {
        public ClearCoat(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return this.Car.GetCost() + 150;
        }

        public override string GetDescription()
        {
            return $"{this.Car.GetDescription()}, Clear Coat";
        }
    }
}
