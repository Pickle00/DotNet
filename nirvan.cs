

class Plane<T>
{

    public T model;
    public T name;
    public Plane(T model, T name)
    {
        this.model = model;
        this.name = name;
    }

    public void display()
    {
        Console.WriteLine(name + " " + model);
    }
}

// internal class Program
// {
//     static void Main(string[] args)
//     {
//         string name = "new";
//         string model = "cloud";

//         int age = 5;
//         int speed = 100;
//         Plane<string> p1 = new Plane<string>(model, name);
//         p1.display();

//         Plane<int> p2 = new Plane<int>(speed, age);
//         p2.display();

//     }
// }