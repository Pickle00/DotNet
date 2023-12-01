using System;

// House product
class House
{
    public string Foundation { get; set; }
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Windows { get; set; }
    public string Doors { get; set; }

    public void Display()
    {
        Console.WriteLine($"Foundation: {Foundation}");
        Console.WriteLine($"Walls: {Walls}");
        Console.WriteLine($"Roof: {Roof}");
        Console.WriteLine($"Windows: {Windows}");
        Console.WriteLine($"Doors: {Doors}");
    }
}

// Builder interface
interface IHouseBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    void BuildWindows();
    void BuildDoors();
    House GetHouse();
}

// Concrete builder
class SimpleHouseBuilder : IHouseBuilder
{
    private House house = new House();

    public void BuildFoundation()
    {
        house.Foundation = "Simple Foundation";
    }

    public void BuildWalls()
    {
        house.Walls = "Simple Walls";
    }

    public void BuildRoof()
    {
        house.Roof = "Simple Roof";
    }

    public void BuildWindows()
    {
        house.Windows = "Simple Windows";
    }

    public void BuildDoors()
    {
        house.Doors = "Simple Doors";
    }

    public House GetHouse()
    {
        return house;
    }
}

// Director
class HouseDirector
{
    private IHouseBuilder houseBuilder;

    public HouseDirector(IHouseBuilder builder)
    {
        houseBuilder = builder;
    }

    public void ConstructHouse()
    {
        houseBuilder.BuildFoundation();
        houseBuilder.BuildWalls();
        houseBuilder.BuildRoof();
        houseBuilder.BuildWindows();
        houseBuilder.BuildDoors();
    }
}

// Example usage
// internal class Program{
//     static void Main(string[] args){
//         IHouseBuilder simpleHouseBuilder = new SimpleHouseBuilder();
//                 HouseDirector houseDirector = new HouseDirector(simpleHouseBuilder);

//                 houseDirector.ConstructHouse();
//                 House simpleHouse = simpleHouseBuilder.GetHouse();

//                 Console.WriteLine("Simple House:");
//                 simpleHouse.Display();
//     }
// }