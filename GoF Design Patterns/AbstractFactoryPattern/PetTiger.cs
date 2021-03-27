using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AbstractFactoryPattern
{
    class PetTiger:ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet tiger voice");
        }

        public void Action()
        {
            Console.WriteLine("Pet tigers play at home");
        }
    }
}
