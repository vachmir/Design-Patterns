using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.ProxyPattern
{
    //Proxy class
    public class Proxy : Subject
    {
        Subject cs;
        public override void DoSomeWork()
        {
            Console.WriteLine("Proxy call happening now...");
            //Lazy initialization: We will not instantiate until the method is called
            if (cs==null)
            {
                cs = new ConcreteSubject();
            }
            cs.DoSomeWork();
        }
    }
}
