// using System;
// public class HelloWorld
// {
//     public void add <T>(T name){
//         Console.WriteLine(name);
//     }
// }

class Generic
{
    public void DisplayElements(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
   
    
    //we can use any Identifier instead of T
    public void GenericDisplay<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    }
}
