using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.AdapterPattern
{
    class Calculator
    {
        public double GetArea (Rect rect)
        {
            return rect.length * rect.width;
        }
    }
}
