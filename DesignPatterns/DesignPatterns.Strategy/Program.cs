// STRATEGY PATTERN
// Useful in situations where we need to choose from similar behaviours dynamically for different classes (types of transmissions in this case)
// Using OOB instead of conditional statements (our requirement can also be achieved by conditionals which check a transmission type enum and then calls relevant function based on that)
// Code reuse (actual shifting logic resides at one place used by all classes)
// Prevents forced changes to classes when behaviours need to change (no need to change the car and motorcycle classes if there is a new type of transmission available)
// Increases number of interfaces and classes (we need the ITransmission interface and respective transmission classes)

namespace DesignPatterns.Strategy
{
    using System;
    using Transmission;
    using Vehicles;

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle hondaS2000 = new Car();
            hondaS2000.Name = "Honda S2000";

            Vehicle yamahaYzfR1 = new Motorcycle();
            yamahaYzfR1.Name = "Yamaha YZF R1";

            Console.WriteLine($"{hondaS2000.Move()} {hondaS2000.Name}");
            Console.WriteLine($"{hondaS2000.Turn()} {hondaS2000.Name}");
            Console.WriteLine($"{hondaS2000.Name} is {hondaS2000.ShiftUp()}");
            Console.WriteLine($"{hondaS2000.Name} is {hondaS2000.ShiftDown()}");
            Console.WriteLine();

            Console.WriteLine($"{yamahaYzfR1.Move()} {yamahaYzfR1.Name}");
            Console.WriteLine($"{yamahaYzfR1.Turn()} {yamahaYzfR1.Name}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.ShiftUp()}");
            Console.WriteLine($"{yamahaYzfR1.Name} is {yamahaYzfR1.ShiftDown()}");
            Console.WriteLine();

            hondaS2000.SetTransmissionType(new ManualTransmission());
            Console.WriteLine($"{hondaS2000.Move()} {hondaS2000.Name}");
            Console.WriteLine($"{hondaS2000.Turn()} {hondaS2000.Name}");
            Console.WriteLine($"{hondaS2000.Name} is {hondaS2000.ShiftUp()}");
            Console.WriteLine($"{hondaS2000.Name} is {hondaS2000.ShiftDown()}");

            Console.ReadKey();
        }
    }
}
