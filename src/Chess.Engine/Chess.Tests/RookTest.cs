using Chess.Library.Pieces;
using Chess.Library;

namespace Chess.Tests;

public class RookTest
{
  [Fact]
  public void CanMoveStraight()
  {
    Rook rook = new Rook(Color.White);
    Spot start = new Spot(rook, new Position(0, 0));
    Spot end = new Spot(null, new Position(0, 5));
    bool canMove = rook.CanMove(
      new Board(),
      start,
      end
      );
    Assert.True(canMove);
  }

}
