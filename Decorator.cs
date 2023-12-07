

public interface IPizza
{
    void prepare();
}

class BasePizza : IPizza
{
    public void prepare()
    {
        Console.WriteLine("Pizza is Ready!");
    }
}

public abstract class PizzaDecorator : IPizza
{

    private readonly IPizza _pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }
    public virtual void prepare()
    {
        _pizza.prepare();
    }
}

public class Pepproni : PizzaDecorator
{
    public Pepproni(IPizza pizza) : base(pizza) { }

    public override void prepare()
    {
        base.prepare();
        Console.WriteLine("Pepproni Toppings Added");
    }
}
public class Pineapple : PizzaDecorator
{
    public Pineapple(IPizza pizza) : base(pizza) { }

    public override void prepare()
    {
        base.prepare();
        Console.WriteLine("Pineapple Toppings Added");
    }
}
public class Baccon : PizzaDecorator
{
    public Baccon(IPizza pizza) : base(pizza) { }

    public override void prepare()
    {
        base.prepare();
        Console.WriteLine("Baccon Toppings Added");
    }
}

