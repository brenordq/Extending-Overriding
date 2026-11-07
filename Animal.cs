/****************************************************************************
* Name: Breanna Gonzalez
* Date: 11.07.2026
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
* Description: Base class representing an Animal. It stores the animal's
* name and number of legs and provides a virtual display method.
*/
using System;

namespace InheritanceOverriding
{
    class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        // Virtual so a derived class can override this method.
        public virtual void PrintAnimal()
        {
            Console.WriteLine($"Animal Name: {Name}");
            Console.WriteLine($"Number of Legs: {Legs}");
        }
    }
}
