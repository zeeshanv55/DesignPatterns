namespace DesignPatterns.Decorator
{
    class Car : ICar
    {
        public Car()
        {
            this.Description = "Basic Car";
            this.Cost = 10000;
        }

        private double Cost { get; set; }

        private string Description { get; set; }

        public double GetCost()
        {
            return this.Cost;
        }

        public string GetDescription()
        {
            return this.Description;
        }
    }
}
