using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    internal interface iWalks
    {
        public int legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Left, Right, Left, Right");
        }

    }
}
