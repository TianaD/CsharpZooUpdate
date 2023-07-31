using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    public abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("Nighty Night");
        }

        public abstract string AnimalType { get; }
        public void DisplayType()
        {
            Console.WriteLine($"This is a: {AnimalType}");
        }

        // public abstract void Move()
        public virtual void Move()
        {
            Console.WriteLine("move");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Yum!");
        }

 /*       public virtual void Move()
        {
            Console.WriteLine("*move forward*");
        }*/
    }
}