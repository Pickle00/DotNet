

class LaptopBuilder
{
    private string os;
    private string processor;
    private string graphics;
    private double size;
    private int battery;


    public Laptop GetLaptop()
    {
        return new Laptop(os, processor, graphics, size, battery);
    }


    public void setOS(string os)
    {
        this.os = os;
    }
    public void setProcessor(string processor)
    {
        this.processor = processor;
    }

    public void setGraphics(string graphics)
    {
        this.graphics = graphics;
    }
    public void setSize(double size)
    {
        this.size = size;
    }

    public void setBattery(int battery)
    {
        this.battery = battery;
    }


}


public class Laptop
{
    private string os;
    private string processor;
    private string graphics;
    private double size;
    private int battery;

    public Laptop(string os, string processor, string graphics, double size, int battery)
    {
        this.os = os;
        this.processor = processor;
        this.graphics = graphics;
        this.size = size;
        this.battery = battery;
    }

    public override string ToString()
    {
        return $"OS: {os}, Processor: {processor}, Graphics: {graphics}, Size: {size}, Battery: {battery}";
    }
}

