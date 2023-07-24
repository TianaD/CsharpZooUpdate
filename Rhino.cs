using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    class Rhino : Mammal
    {
        public void Charge()
        {
            Console.WriteLine("Charrrgee!!!!");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat leaves");
        }

        public override void InhaleExhale()
        {
            Console.WriteLine("Breathe in; Breathe out");
        }

        public override void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}