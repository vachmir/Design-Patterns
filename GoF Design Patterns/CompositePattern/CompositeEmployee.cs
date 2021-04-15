using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.CompositePattern
{
    class CompositeEmployee:IEmployee
    {
        public string Name { set; get; }
        public string Dept { set; get; }
        public string Designation { set; get; }

        private List<IEmployee> subordinteList = new List<IEmployee>();
        public void AddEmpployee(IEmployee e)
        {
            subordinteList.Add(e);
        }
        public void RemoveEmployee(IEmployee e)
        {
            subordinteList.Remove(e);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} works in {Dept} department. Designation {Designation}");
            foreach (IEmployee e in subordinteList)
            {
                e.DisplayDetails();
            }
        }
    }
}
