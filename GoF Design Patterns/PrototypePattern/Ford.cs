﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.PrototypePattern
{
    public class Ford:BasicCar
    {
        public Ford (string m)
        {
            ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Ford) this.MemberwiseClone();
        }
    }
}
