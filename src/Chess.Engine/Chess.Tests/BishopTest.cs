using Chess.Library.Pieces;
using Chess.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Tests
{
  public class BishopTest
  {
    [Fact]
    public void CannotMoveStraight()
    {
      Bishop bishop = new Bishop(Color.White);

      Spot start = new Spot(bishop, new Position(0, 1));
      Spot end = new Spot(null, new Position(0, 3));
      bool canMove = bishop.CanMove(
        new Board(),
        start,
        end
        );
      Assert.False(canMove);
    }
    [Fact]
    public void CanMoveDiagonal()
    {
      Bishop bishop = new Bishop(Color.White);

      Spot start = new Spot(bishop, new Position(0, 0));
      Spot end = new Spot(null, new Position(8, 8));
      bool canMove = bishop.CanMove(
        new Board(),
        start,
        end
        );
      Assert.True(canMove);
    }
  }
}
