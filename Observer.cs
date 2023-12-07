

using System.Net.Mail;

public interface IObserver
{
    void Update();
}


class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    private int state;

    public int State
    {
        get { return state; }

        set
        {
            state = value;
            NotifyObservers();
        }

    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer); //Added to the List
    }


    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }

}

class ConstructObserver : IObserver{
    private readonly Subject subject;

    public ConstructObserver(Subject subject){
        this.subject = subject;
        //Calls AddObserver Method from Subject class Passing the instance(this) of observer1 from main method to add to the List;
        this.subject.AddObserver(this);
    }

    public void Update(){
        Console.WriteLine($"Observer received an update. New State: {subject.State}");
    }
}

public class Observer{
    static void Main(string[] args){
        Subject subject = new Subject();
        ConstructObserver observer1 = new ConstructObserver(subject);//subject passes the instance of class Subject
        ConstructObserver observer2 = new ConstructObserver(subject);

        subject.State = 1;
    }
}