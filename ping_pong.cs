using System;
using System.Collections.Generic;
using PingPong.Play;

namespace PingPong
{
  public class PingPong
  {
    public static void Main()
    {
      Console.WriteLine("How high do you want to go [enter an integer 1 or greater]:");
      string stringNumber = Console.ReadLine();
      int maxNumber = int.Parse(stringNumber);
      if (maxNumber < 1 || maxNumber == Double.NaN)
      {
        Console.WriteLine("Please enter a valid number!");
        Main();
      }
      else
      {
        List<string> outputList = PingPongGame.PlayPingPong(maxNumber);
        foreach(string entry in outputList)
        {
          Console.WriteLine(entry);
        }
      }
    }
  }
}