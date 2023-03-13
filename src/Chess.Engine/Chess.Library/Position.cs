using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Library
{
  public class Position
  {
    private int _x, _y;
    public int X 
    { 
      get { return _x; }
      set{ _x = value;} 
    }
    public int Y
    {
      get { return _y; }
      set { _y = value; }
    }

    public Position(int x, int y)
    {
      _x = x;
      _y = y;
    }
    public bool IsValid()
    {
      return _x <= 7 && _x >= 0 && _y <= 7 && _y >= 0;
    }
  }
}
