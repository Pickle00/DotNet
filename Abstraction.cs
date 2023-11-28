
abstract class Animal{
    public abstract void animalsound();

    public void sleep(){
        Console.WriteLine("ZZzzz");
    }
    
}

class Dog : Animal{
    public override void animalsound(){
        Console.WriteLine("Bark! Bark!");
    }
}

