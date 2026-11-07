/****************************************************************************
* Name: Breanna Gonzalez
* Date: 11.07.2026
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
* Description: Main application that creates Animal and Cat objects,
* displays their properties, updates them, and displays
* their updated properties.
*/
using System;

namespace InheritanceOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breanna Gonzalez - Week 5 PA Inheritance and Overriding.");
            Console.WriteLine();

            // Create an instance of each class.
            Animal animal = new Animal("Rachel", 2);
            Cat cat = new Cat("Mandy", 4, "Meow");

            // Display original properties.
            Console.WriteLine("Original Animal Information:");
            animal.PrintAnimal();

            Console.WriteLine("\nOriginal Cat Information:");
            cat.PrintAnimal();

            // Update each object's properties.
            animal.Name = "Tank";
            animal.Legs = 4;

            cat.Name = "Kyra";
            cat.Legs = 3;
            cat.Sound = "Rawr";

            // Display updated properties.
            Console.WriteLine("\nUpdated Animal Information:");
            animal.PrintAnimal();

            Console.WriteLine("\nUpdated Cat Information:");
            cat.PrintAnimal();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

