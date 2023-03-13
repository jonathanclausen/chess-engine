using Chess.Library.Pieces;
using Chess.Library;

namespace Chess.Tests;

public class PawnTest
{
  [Fact]
  public void CanMove2AheadOnStart()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 1));
    Spot end = new Spot(null, new Position(0, 3));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.True(canMove);
  }

  [Fact]
  public void CanMove1AheadOnStart()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 1));
    Spot end = new Spot(null, new Position(0, 2));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.True(canMove);
  }
  [Fact]
  public void CannotMoveDiagonalWithoutTaking()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 1));
    Spot end = new Spot(null, new Position(1, 2));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.False(canMove);
  }
  [Fact]
  public void CannotMove2AfterFirstMove()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 2));
    Spot end = new Spot(null, new Position(0, 4));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.False(canMove);
  }
  [Fact]
  public void CannotMoveBackwards()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 4));
    Spot end = new Spot(null, new Position(0, 3));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.False(canMove);
  }
  [Fact]
  public void CannotMoveSideways()
  {
    Pawn pawn = new Pawn(Color.White);

    Spot start = new Spot(pawn, new Position(0, 4));
    Spot end = new Spot(null, new Position(1, 4));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.False(canMove);
  }
  [Fact]
  public void CanMoveDiagonalIfTaking()
  {
    Pawn pawn = new Pawn(Color.White);
    Pawn takeThisPawn = new Pawn(Color.Black);
    Spot start = new Spot(pawn, new Position(0, 3));
    Spot end = new Spot(takeThisPawn, new Position(1, 4));
    bool canMove = pawn.CanMove(
      new Board(),
      start,
      end
      );
    Assert.True(canMove);
  }

}
