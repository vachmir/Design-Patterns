﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.CompositePattern
{
    interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }
        string Designation { get; set; }
        void DisplayDetails();
    }
}
