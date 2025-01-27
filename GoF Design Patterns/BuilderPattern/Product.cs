﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.BuilderPattern
{
    class Product
    {
        // We can use any data structure that you prefer, e.g.List<string> etc.
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            //Adding parts of car
            parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\n Product Completed ");
            foreach (string part  in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
