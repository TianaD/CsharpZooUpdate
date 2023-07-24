using CsharpZoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    public class Eagle : Bird, Move
    {

        int wingspan = 13;
        public override void Fly()
        {
            Console.WriteLine("I'm as free as a bird!");
        }
        public override void Breathe()
        {
            Console.WriteLine("Inhale . . .Exhale");
        }
        public override void Move()
        {
            Console.WriteLine("Tip Tap");
        }
    }
}