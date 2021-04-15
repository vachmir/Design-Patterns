using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.CompositePattern
{
    class Employee : IEmployee
    {
        public string Name { get; set ; }
        public string Dept { get; set; }
        public string Designation { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} works in {Dept} department. Designation {Designation}");
        }
    }
}
