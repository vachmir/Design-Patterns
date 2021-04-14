using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FacadePattern.RobotParts
{
    class RobotColor
    {
        public void SetDefaultColor()
        {
            Console.WriteLine("Steel color robot.");
        }

       public void SetGreenColor()
        {
            Console.WriteLine("Green color.");
        }
    }
}
