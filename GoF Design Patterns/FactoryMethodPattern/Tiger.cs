using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FactoryMethodPattern
{
    class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Tiger Voice");
        }

        public void Action()
        {
            Console.WriteLine("Hunting");
        }
    }
}
