using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AbstractFactoryPattern
{
    //Abstract Factory

    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
