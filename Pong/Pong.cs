using System;
using System.Collections.Generic;

//namespace PingPong;
public class PingPongGame
{
  public void Run()
  {
    Console.WriteLine("Plz enter a number:");
    string inputtedNumber = Console.ReadLine();
    int number = int.Parse(inputtedNumber);
    for (int i = 1; i <= number; i++)
    {
      string message = ReturnMessage(i);
      Console.WriteLine(message);
    }
  }

  public string ReturnMessage(int number)
  {
    if (number % 3 == 0 && number % 5 == 0)
    {
      return "pingpong";
    }
    else if (number % 3 == 0)
    {
      return "ping";
    }
    else if (number % 5 == 0)
    {
      return "pong";
    }
    else
    {
      return number.ToString();
    }
  }
}

public class Program
{
  public static void Main()
  {
    PingPongGame game = new PingPongGame();
    game.Run();
  }
}
