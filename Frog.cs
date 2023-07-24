using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    public class Frog : Animal, InhaleExhale
    {
        public Frog()
        {
            Console.WriteLine("rrrrrrrrrribbit");
        }
        public override void Sleep()
        {
            Console.WriteLine("Ribbit Ribbit *Rabbit snoring?*");
        }
        public void Inhale()
        {
            Console.WriteLine("*Inhale* Croak");
        }
        public void Exhale()
        {
            Console.WriteLine("*Exhale* Croack");
        }
        public override void Move()
        {
            Console.WriteLine("Hop Hop . . . Hop");
        }
    }
}