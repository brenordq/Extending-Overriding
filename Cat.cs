/****************************************************************************
* Name: Breanna Gonzalez
* Date: 11.07.2026
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
* Description: Cat class derived from Animal. It inherits the name and
* number of legs, adds a sound property, and overrides the
* PrintAnimal method to display all Cat properties.
*/
using System;

namespace InheritanceOverriding
{
    class Cat : Animal
    {
        public string Sound { get; set; }

        public Cat(string name, int legs, string sound)
            : base(name, legs)
        {
            Sound = sound;
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Cat Name: {Name}");
            Console.WriteLine($"Number of Legs: {Legs}");
            Console.WriteLine($"Cat Sound: {Sound}");
        }
    }
}
