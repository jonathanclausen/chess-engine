using System;
namespace Chess.Library
{
  public class Move
  {
    public Spot Start { get; private set; }
    public Spot To { get; private set; }
    public Move()
    {
    }
  }
}

