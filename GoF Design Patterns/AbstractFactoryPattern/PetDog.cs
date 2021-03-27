using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AbstractFactoryPattern
{
    class PetDog:IDog
    {
        public void Speak()
        {
            Console.WriteLine( "Pet dog voice");
        }

        public void Action()
        {
            Console.WriteLine( "Pet dogs stay at home");
        }
    }
}
