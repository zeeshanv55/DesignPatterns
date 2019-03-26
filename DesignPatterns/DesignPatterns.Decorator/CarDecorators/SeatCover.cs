namespace DesignPatterns.Decorator.CarDecorators
{
    class SeatCover : CarDecorator
    {
        public SeatCover(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return this.Car.GetCost() + 100;
        }

        public override string GetDescription()
        {
            return $"{this.Car.GetDescription()}, Seat Covers";
        }
    }
}
