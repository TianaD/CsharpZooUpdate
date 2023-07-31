using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    // abstract classes are meant to be inherited from not instantiated
    public abstract class Mammal : Animal
    {
        public string FurColor;

        public override string AnimalType => "Mammal";


        public string Breathe;

        public override void Eat()
        {
            Console.WriteLine("What aaaaare you eating??");
        }

    }
}