using System;
using System.Text;

using GoF_Design_Patterns.AbstractFactoryPattern;
using GoF_Design_Patterns.BuilderPattern;
using GoF_Design_Patterns.FactoryMethodPattern;
using GoF_Design_Patterns.PrototypePattern;
using GoF_Design_Patterns.SingletonPatternEx;

using GoF_Design_Patterns.ProxyPattern;
using GoF_Design_Patterns.DecoratorPattern;
using GoF_Design_Patterns.AdapterPattern;
using GoF_Design_Patterns.FacadePattern;
using GoF_Design_Patterns.FlyweightPattern;

namespace GoF_Design_Patterns
{

    class Program
    {
        static void Main(string[] args)
        {
            //Creational Patterns
            Console.WriteLine("Creational Patterns");
            #region Singleton
            Console.WriteLine("***Singleton Pattern Demo***\n");

            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exists.");
            }
            #endregion
            
            Console.WriteLine("###########################");

            #region Prototype
            Console.WriteLine("***Prototype Pattern Demo***\n");
            //Base or Original
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000};
            BasicCar ford_base = new Ford("FordYellow") { Price = 500000 };
            BasicCar bc1;

            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is {bc1.ModelName}, and price is {bc1.Price}");

            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is {bc1.ModelName}, and price is {bc1.Price}");
            #endregion

            Console.WriteLine("###########################");

            #region Buuilder
            Console.WriteLine("***Builder Pattern Demo***");
            Director director = new Director();

            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new MotorCycle("Honda");

            //Mking Car
            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();

            //Making Motorcycle 
            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();
            #endregion

            Console.WriteLine("###########################");

            #region Factory Method Pattern
            Console.WriteLine("***Factory Pattern Demo***\n");

            // Creating a Tiger Factory
            AnimalFactory tigerFactory = new TigerFactory();
            // Creating a tiger using the Factory Method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.AboutMe();
            aTiger.Action();

            // Creating a DogFactory
            AnimalFactory dogFactory = new DogFactory();
            // Creating a dog using the Factory Method
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.AboutMe();
            aDog.Action();
            #endregion

            Console.WriteLine("###########################");

            #region Abstract Factory Pattern

            Console.WriteLine("***Abstract Factory Pattern Demo***\n");
            //Making a wild dog through WildAnimalFactory
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IDog wildDog = wildAnimalFactory.GetDog();

            wildDog.Speak();
            wildDog.Action();
            //Making a wild tiger through WildAnimalFactory
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();
            Console.WriteLine("******************");
            //Making a pet dog through PetAnimalFactory
            IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();
            //Making a pet tiger through PetAnimalFactory
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();
            #endregion

            Console.WriteLine("###########################");

            //Structural Patterns
            Console.WriteLine("Structural Patterns");

            #region Proxy Pattern
            Console.WriteLine("***Proxy Pattern Demo***");
            Proxy px = new Proxy();
            px.DoSomeWork();
            #endregion

            Console.WriteLine("###########################");

            #region Decorator Pattern
            Console.WriteLine("***Decorator Pattern Simulation***");
            ConcreteComponent cc = new ConcreteComponent();
 
            ConcreteDecoratorEx1 decorator1 = new ConcreteDecoratorEx1();
            decorator1.SetTheComponent(cc);
            decorator1.MakeHouse();

            ConcreteDecoratorEx2 decorator2 = new ConcreteDecoratorEx2();
            //Adding results from decorator1
            decorator2.SetTheComponent(decorator1);
            decorator2.MakeHouse();
            #endregion

            Console.WriteLine("###########################");

            #region Adapter Pattern

            Console.WriteLine("***Adapter Pattern Demo***\n");
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is {cal.GetArea(t)} square unit");

            #endregion

            Console.WriteLine("###########################");

            #region Facade Pattern

            Console.WriteLine("***Facade Pattern Demo***");
            RobotFacade robotFacade1 = new RobotFacade(); // Creating Robots
            robotFacade1.ConstructMilanoRobot();

            RobotFacade robotFacade2 = new RobotFacade(); // Creating Robots
            robotFacade2.ConstructRobonautRobot();

            robotFacade1.DestroyMilanoRobot();            //Destroying Robots
            robotFacade2.DestroyRobonautRobot();
            #endregion

            Console.WriteLine("###########################");

            #region Flyweight Pattern
            Console.WriteLine("***Flyweight Pattern Demo***");
            RobotFactory myFactory = new RobotFactory();
            IRobot shape = myFactory.GetRobotFromFactory("Small");
            shape.Print();

            //Creating small robots
            for (int i = 0; i < 2; i++)
            {
                shape = myFactory.GetRobotFromFactory("Small");
                shape.Print();
            }

            int numOfDistinctRobots = myFactory.TotalObjectsCreated;
            Console.WriteLine($"Number of distinct robot objects is {numOfDistinctRobots}");

            //Creating large robots
            for (int i = 0; i < 5; i++)
            {
                shape = myFactory.GetRobotFromFactory("Large");
                shape.Print();
            }

            numOfDistinctRobots = myFactory.TotalObjectsCreated;
            Console.WriteLine($"Distinct robot objects created till now {numOfDistinctRobots}");
            #endregion

        }


    }
}
