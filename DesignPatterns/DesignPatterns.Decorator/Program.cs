// DECORATOR PATTERN
// Useful for dynamically modifying an object
// Uses the capabilities of inheritence and adds functionality at runtime. Uses composition.
// Can be easily extented by adding small decorator classes which add functionality to a basic object.

namespace DesignPatterns.Decorator
{
    using System;
    using CarDecorators;

    class Program
    {
        static void Main(string[] args)
        {
            var basicCar = new Car();
            Console.WriteLine($"Basic car description: {basicCar.GetDescription()}");
            Console.WriteLine($"Basic car cost: {basicCar.GetCost()}");
            Console.WriteLine();

            var mattePaintCar = new MattePaint(new Car());
            Console.WriteLine($"Matte paint car description: {mattePaintCar.GetDescription()}");
            Console.WriteLine($"Matte paint car cost: {mattePaintCar.GetCost()}");
            Console.WriteLine();

            var familyCar = new SeatCover(new ClearCoat(new Car()));
            Console.WriteLine($"Family car description: {familyCar.GetDescription()}");
            Console.WriteLine($"Family car car cost: {familyCar.GetCost()}");
            Console.WriteLine();

            var sportsCar =  new RearSpoiler(new SeatCover(new ClearCoat(new MattePaint(new Car()))));
            Console.WriteLine($"Sports car description: {sportsCar.GetDescription()}");
            Console.WriteLine($"Sports car car cost: {sportsCar.GetCost()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
