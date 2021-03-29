using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Design_Patterns.DecoratorPattern
{
    class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using another decoration***");
            //Decorating now.
            PaintTheHouse();

        }

        private void PaintTheHouse()
        {
            Console.WriteLine("House painting");
        }
    }
}
