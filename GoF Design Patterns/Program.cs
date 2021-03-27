﻿using System;
using GoF_Design_Patterns.AbstractFactoryPattern;
using GoF_Design_Patterns.BuilderPattern;
using GoF_Design_Patterns.FactoryMethodPattern;
using GoF_Design_Patterns.PrototypePattern;
using GoF_Design_Patterns.SingletonPatternEx;

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

            Console.Read();
        }
    }
}