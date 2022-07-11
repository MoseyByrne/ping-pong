using System;


  public class PingPong
{
  public static void Main()
  {
     Console.WriteLine("enter a positive number");
     string stringUserNumber = Console.ReadLine();
     int userNumber = int.Parse(stringUserNumber);

     Console.WriteLine("here is your pingpong list");
     for (int i = 1; i <= userNumber; i++)
     {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping Pong!");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(i);
      }
     }    
  }
}
