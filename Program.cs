using System;
// using Bike;


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
            // Bike.MyBike myBike = new Bike.MyBike();
            // MyBike b = new MyBike();
            // myBike.start();
            // myBike.stop();
            // bike.Dirtbike mybike = new bike.Dirtbike();
            // bike.start();
            // bike.stop();


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
            
            Console.WriteLine ("Hello Mono World");
            HelloWorld obj = new HelloWorld();
            obj.add<string>("my name");
        }
    }
}
