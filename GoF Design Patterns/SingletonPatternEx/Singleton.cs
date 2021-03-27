using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.SingletonPatternEx
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;

        private Singleton()
        {
            Console.WriteLine("Inside private constructor");
            numberOfInstances++;
            Console.WriteLine($"Number of instances {numberOfInstances}");
        }

        public static Singleton Instance
        {
            get
            {
               /* if(instance==null)
                { 
                    instance = new Singleton();
                }*/
                Console.WriteLine("We already have an instance now. Use that!");
                return instance;
            }
        }

        //public static int MyInt = 25;
    }
}
