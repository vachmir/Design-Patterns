using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AbstractFactoryPattern
{
    class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Wild tiger voice");
        }
        public void Action()
        {
            Console.WriteLine("WIld tigers are in jungle");
        }
    }
}
