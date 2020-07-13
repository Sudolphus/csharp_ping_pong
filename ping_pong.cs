using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
    public static void Main()
    {
      Console.WriteLine("How high do you want to go [enter an integer 1 or greater]:");
      string stringNumber = Console.ReadLine();
      int maxNumber = int.Parse(stringNumber);
      List<string> outputList = playPingPong(maxNumber);
      foreach(string entry in outputList)
      {
        Console.WriteLine(entry);
      }
    }
  }
}