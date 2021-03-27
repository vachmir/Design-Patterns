using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Design_Patterns.BuilderPattern;

namespace GoF_Design_Patterns.BuilderPattern
{
    class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {//Start with brandname
            product.Add(string.Format($"Car Model name {this.brandName}"));
        }

        public void BuildBody()
        {
            product.Add("This is body of a Car");
        }

        public void InsertWheels()
        {
            product.Add("4 whels are added");
        }

        public void AddHeadlights()
        {
            product.Add("2 Headlights are addes");
        }
        public void EndOperations()
        { //Nothing in this case
        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}
