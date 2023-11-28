interface IPrey{
    void run();
}

interface IPredator{
    void hunt();
}

class Rabbit : IPrey{
    public void run(){
        Console.WriteLine("The rabbit runs away!");
    }
}

class Eagle : IPredator{
    public void hunt(){
        Console.WriteLine("The Eagle is searching for food");
    }
}

class Fish : IPrey, IPredator{
    public void hunt(){
        Console.WriteLine("The fish is searching for smaller fish");

    }

    public void run(){
        Console.WriteLine("The fish runs away!");
    }
}
