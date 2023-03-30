using System;
namespace Chess.Library.Pieces
{
  public class Knight : Piece
  {
    public Knight(Color color) : base(color) { }

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      var validMove = Math.Abs((start.Position.X - end.Position.X) * (start.Position.Y - end.Position.Y)) == 2;
      if (!validMove) { return false; }

      if (end.Piece?.Color == Color) { return false; }
      return true;
    }
  }
}

