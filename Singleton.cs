

namespace SingletonDemo{
    public sealed class Singletonclass{
      private static Singletonclass instance = null;

      private Singletonclass(){

      }

      public static Singletonclass Instance{
        get{
            if(instance == null){
                instance = new Singletonclass();
            }
            return instance;
        }
      }

      public void DisplayMessage(){
        Console.WriteLine("I am a message");
      }
    }
}