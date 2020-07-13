using System.Collections.Generic;

namespace PingPong.Play
{
  public class PingPongGame
  {
    public static List<string> PlayPingPong(int maxNumber)
    {
      List<string> outputList = new List<string>(0);
      for (int i = 1; i <= maxNumber; i++)
      {
        if (i % 15 == 0)
        {
          outputList.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          outputList.Add("ping");
        }
        else if (i % 5 == 0)
        {
          outputList.Add("pong");
        }
        else
        {
          outputList.Add(i.ToString());
        }
      }
      return outputList;
    }
  }
}