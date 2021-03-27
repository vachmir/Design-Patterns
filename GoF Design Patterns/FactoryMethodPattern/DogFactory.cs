using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FactoryMethodPattern
{
    class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
