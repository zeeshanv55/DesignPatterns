// ABSTRACT FACTORY PATTERN
// Similar to factory with everything encapsulated
// Can be understood as a combination of strategy and factory patterns
// Final objects have strategy pattern for various sub objects
// Final objects are themselves created using a factory, and the 'strategy' is implemented using an abstract factory

namespace DesignPatterns.AbstractFactory
{
    using System;
    using AbstractFactories;
    using Vehicles;
    using Vehicles.Transmissions;

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new VehicleAbstractFactory();

            var toyotaYaris = (Car)factory.GetVehicle(VehicleType.Car);
            toyotaYaris.Name = "Toyota Yaris";
            toyotaYaris.MaxSpeed = 150;
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.Start()}");
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.ShiftUp()}");
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.Move()}");
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.Turn()}");
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.ShiftDown()}");
            Console.WriteLine($"{toyotaYaris.Name} is {toyotaYaris.Stop()}");
            Console.WriteLine();

            var yamahaYzfR1 = (Motorcycle)factory.GetVehicle(VehicleType.Motorcycle);
            yamahaYzfR1.Name = "Yamaha YZF R1";
            yamahaYzfR1.MaxSpeed = 300;
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.Start()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.ShiftUp()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.Move()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.Turn()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.ShiftDown()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.Stop()}");
            Console.WriteLine();

            var fordF150 = (Truck)factory.GetVehicle(VehicleType.Truck);
            fordF150.Name = "Ford F150";
            fordF150.MaxSpeed = 180;
            Console.WriteLine($"{fordF150.Name} is {fordF150.Start()}");
            Console.WriteLine($"{fordF150.Name} is {fordF150.ShiftUp()}");
            Console.WriteLine($"{fordF150.Name} is {fordF150.Move()}");
            Console.WriteLine($"{fordF150.Name} is {fordF150.Turn()}");
            Console.WriteLine($"{fordF150.Name} is {fordF150.ShiftDown()}");
            Console.WriteLine($"{fordF150.Name} is {fordF150.Stop()}");
            Console.WriteLine();

            var fordMustang = (Car)factory.GetVehicle(VehicleType.Car);
            fordMustang.SetTransmission(new ManualTransmission());
            fordMustang.Name = "Ford Mustang";
            fordMustang.MaxSpeed = 250;
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.Start()}");
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.ShiftUp()}");
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.Move()}");
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.Turn()}");
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.ShiftDown()}");
            Console.WriteLine($"{fordMustang.Name} is {fordMustang.Stop()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
