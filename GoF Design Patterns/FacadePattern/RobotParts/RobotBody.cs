using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.FacadePattern.RobotParts
{
    class RobotBody
    {
        public void CreateHands()
        {
            Console.WriteLine("Hands");
        }

        public void CreateRemainingParts()
        {
            Console.WriteLine("Remaining parts (other than hands) are created");
        }
        public void DestroyHands()
        {
            Console.WriteLine("The robot's hands are destroyed");
        }
        public void DestroyRemainingParts()
        {
            Console.WriteLine("The robot's remaining parts are destroyed");
        }
    }
}
