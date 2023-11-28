using System;
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

            //Property
            BankAc bank = new BankAc();
            bank.AccHolder = "Bikal";
            bank.Balance = 1000;
            Console.WriteLine($"Account Holder: {bank.AccHolder}");
            Console.WriteLine($"Balance: {bank.Balance}");
        }
    }
