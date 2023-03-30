using Chess.Library.Pieces;
using Chess.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Tests
{
  public class KnightTest
  {
    [Fact]
    public void CanMove()
    {
      Bishop knight = new Bishop(Color.White);

      Spot start = new Spot(knight, new Position(1, 0));
      Spot end = new Spot(null, new Position(2, 2));
      bool canMove = knight.CanMove(
        new Board(),
        start,
        end
        );
      Assert.True(canMove);
    }
    [Fact]
    public void CannotMakeIllegalMove()
    {
      Bishop knight = new Bishop(Color.White);

      Spot start = new Spot(knight, new Position(1, 0));
      Spot end = new Spot(null, new Position(2, 4));
      bool canMove = knight.CanMove(
        new Board(),
        start,
        end
        );
      Assert.False(canMove);
    }
  }
}
