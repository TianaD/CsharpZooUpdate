using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    // This is a public abstract class named Bird that inherits from the Animal class.
    public abstract class Bird : Animal, iWalks
    {
        // This is an integer variable named WingSpan.
        int WingSpan;

        // This is a public override string property named AnimalType that returns "Bird".
        public override string AnimalType => "Bird";

        // This is a public void method named DisplayType that writes to the console the string "This animal is a: {AnimalType}".
        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        // This is a public abstract void method named Fly that has no implementation.
        public abstract void Fly();

        public override void Eat()
        {
            Console.WriteLine("MMMMMM, WORMS!");
        }

        public int legs { get; set; }
    }
}
