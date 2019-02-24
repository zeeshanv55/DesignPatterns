// FACTORY METHOD PATTERN
// Useful when a class from a group of classes is to be decided on runtime
// Class selection code is centralized, maintaining code when new classes are added is easy
// Callers don't need to know about all subclasses

namespace DesignPatterns.Factory
{
    using System;
    using Factories;
    using Vehicles;

    class Program
    {
        static void Main(string[] args)
        {
            var fordMustang = new Car("Ford Mustang");
            fordMustang.MaxSpeed = 200;

            Console.WriteLine($"{fordMustang.Name} is {fordMustang.Move()}");
            Console.WriteLine();

            var hondaS2000 = (Car)VehicleFactory.GetVehicle(VehicleType.Car);
            hondaS2000.Name = "Honda S2000";
            hondaS2000.MaxSpeed = 220;

            var yamahaYzfR1 = (Motorcycle)VehicleFactory.GetVehicle(VehicleType.Motorcycle);
            yamahaYzfR1.Name = "Yamaha YZF R1";
            yamahaYzfR1.MaxSpeed = 300;

            var fordF150 = (Truck)VehicleFactory.GetVehicle(VehicleType.Truck);
            fordF150.Name = "Ford F150";
            fordF150.MaxSpeed = 140;

            var boatyMcBoatface = (Boat)VehicleFactory.GetVehicle(VehicleType.Boat);
            boatyMcBoatface.Name = "Boaty McBoatface";
            boatyMcBoatface.MaxSpeed = 80;

            Console.WriteLine($"{hondaS2000.Name} is {hondaS2000.Move()}");
            Console.WriteLine();
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.Move()}");
            Console.WriteLine();
            Console.WriteLine($"{fordF150.Name} is {fordF150.Move()}");
            Console.WriteLine();
            Console.WriteLine($"{boatyMcBoatface.Name} is {boatyMcBoatface.Move()}");

            Console.ReadKey();
        }
    }
}
