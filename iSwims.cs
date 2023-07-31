using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    public interface iSwims
    {
        public bool inWater { get; set; }
        public void Swim()
        {
            Console.WriteLine("Splish Splash");
        }
    }
}
