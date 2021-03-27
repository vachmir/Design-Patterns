using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FactoryMethodPattern
{
    class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Dog  voice");
        }
        
        public void Action()
        {
            Console.WriteLine("Running");
        }
    }
}
