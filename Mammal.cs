using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    public abstract class Mammal : Animal
    {
        public string FurColor;

        public override string AnimalType => "Mammal";
        public void DisplayType()
        {
            Console.WriteLine($"This is a: {AnimalType}");
        }

    }
}