using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    class Rhino : Mammal, iWalks, // Breathe
    {
        public int legs { get; set; }
        public void Charge()
        {
            Console.WriteLine("Charrrgee!!!!");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat leaves");
        }

        public string InhaleExhale { get; set; }


        public override void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}