using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Library
{
  public class Board
  {
    private Spot[][] _squares;

    public Board()
    {
      Initialize();
    }

    public void Initialize()
    {
      SetupPieces();
    }

    public Spot GetSquare(Position position)
    {
      if (position.IsValid())
        return _squares[position.X][position.Y];
      else
        throw new IndexOutOfRangeException($"Position is outside of the board: x={position.X}, y={position.Y}");
    }

    public void SetupPieces()
    {
      //_squares[0][0] = new Spot()
    }
  }
}
