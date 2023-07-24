using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpZoo
{
    interface Move
    {
        public int Legs { get; set; }

        public void Move();
    }

}