using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AbstractFactoryPattern
{
    class WildDog :IDog
    {
        public void Speak()
        {
            Console.WriteLine("Dog voice");
        }

        public void Action()
        {
            Console.WriteLine("Wild Dogs are in jungles");
        }
    }
}
