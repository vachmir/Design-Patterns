using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FlyweightPattern
{
    /// <summary>
    /// ConcreteFlyweight class
    /// </summary>
    class LargeRobot :IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is large robot");
        }
    }
}
