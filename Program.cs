using System;
using System.Security.Cryptography.X509Certificates;
using Bike;
using SingletonDemo;


namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ShapeDemo Concepts of OOP

            // Shape s1, s2;
            // s1 = new Square(3);
            // s2 = new Rectangle(2, 3);
            // CompositeShape c = new CompositeShape(s1, s2);
            // Console.WriteLine(c.getArea());


            //Private variable
            // Bike mybike = new Bike();
            // mybike.display();


            //Inheritance
            // Car mycar = new Car();
            // mycar.sound();
            // Console.WriteLine(mycar.modelName);


            // MultiLevel-Inhertance
            // Dirtbike myBike = new Dirtbike();
            // myBike.start();
            // myBike.stop();


            //Property
            // BankAc bank = new BankAc();
            // bank.AccHolder = "Bikal";
            // bank.Balance = 1000;
            // Console.WriteLine($"Account Holder: {bank.AccHolder}");
            // Console.WriteLine($"Balance: {bank.Balance}");


            //Abstraction
            // Dog myDog = new Dog();
            // myDog.animalsound();
            // myDog.sleep();


            //Interfaces
            // Rabbit rabbit = new Rabbit();
            // rabbit.run();
            // Eagle eagle = new Eagle();
            // eagle.hunt();
            // Fish fish = new Fish();
            // fish.run();
            // fish.hunt();

            
            //Generic
            // Console.WriteLine ("Hello Mono World");
            // HelloWorld obj = new HelloWorld();
            // obj.add<string>("my name");

            // int[] intArray = {1, 2, 3};
            // double[] doubleArray = {1.0, 2.0, 3.0};
            // String[] stringArray ={"Knee", "Tika", "Nitika"};

            // Generic generic = new Generic();
            // generic.DisplayElements(intArray);

            // //Arguments passed through same method
            // generic.GenericDisplay(doubleArray);
            // generic.GenericDisplay(stringArray);


            //Singleton
            Message m1 = new Message();
            Message m2 = new Message();

            //Different Instance Output comes FALSE
            Console.WriteLine(m1==m2);

            Singletonclass singletonInstance = Singletonclass.Instance;

            singletonInstance.DisplayMessage();

            Singletonclass anotherInstance = Singletonclass.Instance;

            Console.WriteLine(singletonInstance==anotherInstance);

        }
    }

    class Message(){
        public void dismessage(){
                Console.WriteLine("This is a message");
            }

    }
}
