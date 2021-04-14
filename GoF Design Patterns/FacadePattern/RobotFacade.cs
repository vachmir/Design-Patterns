using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Design_Patterns.FacadePattern.RobotParts;

namespace GoF_Design_Patterns.FacadePattern
{
    class RobotFacade
    {
        RobotColor rc;
        RobotHands rh;
        RobotBody rb;
        public RobotFacade()
        {
            rc = new RobotColor();
            rh = new RobotHands();
            rb = new RobotBody();
        }

        public void ConstructMilanoRobot()
        {
            Console.WriteLine("Creation of Milano Robot Start");
            rc.SetDefaultColor();
            rh.SetMilanoHands();
            rb.CreateHands();
            rb.CreateRemainingParts();
            Console.WriteLine("Milano Robot Creation End");
            Console.WriteLine();
        }

        public void ConstructRobonautRobot()
        {
            Console.WriteLine("Initiating the creationnal process of a Robonaut Robot");
            rc.SetGreenColor();
            rh.SetRobonautHands();
            rb.CreateHands();
            rb.CreateRemainingParts();
            Console.WriteLine("A Robonaut is created");
        }

        public void DestroyMilanoRobot()
        {
            Console.WriteLine("Milano Robot's destruction process is started");
            rh.ResetMilanoHands();
            rb.DestroyHands();
            rb.DestroyRemainingParts();
            Console.WriteLine("Milano Robot Destruction process is over");
        }

        public void DestroyRobonautRobot()
        {
            Console.WriteLine("Initiating a Robonaut Robot's destruction process.");
            rh.ResetRobonautHands();
            rb.DestroyHands();
            rb.DestroyRemainingParts();
        }
    }
}
