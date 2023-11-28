using System;

class Bike
{
    private string model = "Ninja";
    public string name;

    Bike(){
        name = "";
    }

   public void display()
    {
        name = model;
        Console.WriteLine(name);
    }
}
