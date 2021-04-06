using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AdapterPattern
{
    class Triangle
    {
        public double baseT; //base
        public double height; //height
        public Triangle(int b, int h)
        {
            this.baseT = b;
            this.height = h;
        }
    }
}
