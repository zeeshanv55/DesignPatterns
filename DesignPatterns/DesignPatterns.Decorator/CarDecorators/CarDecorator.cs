namespace DesignPatterns.Decorator.CarDecorators
{
    abstract class CarDecorator : ICar
    {
        protected ICar Car { get; set; }

        public CarDecorator(ICar car)
        {
            this.Car = car;
        }

        public abstract double GetCost();

        public abstract string GetDescription();
    }
}
