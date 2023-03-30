using System;
namespace Chess.Library.Pieces
{
  public class Queen : Piece
  {
    public Queen(Color color) : base(color) { }

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      // check diagonal
      var distX = Math.Abs(end.Position.X - start.Position.X);
      var distY = Math.Abs(end.Position.Y - start.Position.Y);

      if (distX == distY) // moving diagonal
      {
        Spot spot = start.Position.Y < end.Position.Y ? start : end;
        spot.Position.X++;
        spot.Position.Y++;
        for(int i = 0; i < distX; i++)
        {
          if (spot.HasPiece())
            return false;
          spot = board.GetSpot(new Position(start.Position.X++, start.Position.Y++));
        }
      }
      if (end.Position.X == start.Position.X || end.Position.Y == start.Position.Y) // moving straight
      {
        bool movingOnX = end.Position.X == start.Position.X;
        Position pos;
        if (movingOnX)
          pos =  start.Position.Y < end.Position.Y ? new Position(start.Position) : new Position(end.Position);
        else
          pos = start.Position.X < end.Position.X ? new Position(start.Position) : new Position(end.Position);

        var dist = movingOnX
          ? Math.Abs(end.Position.Y - start.Position.Y)
          : Math.Abs(end.Position.X - start.Position.X);

        for(int i = 0; i < dist; i++)
        {
          if (movingOnX)
          {
            pos.Y++;
            board.GetSpot(pos).HasPiece();
          }
        }

      }
        

      if (end.HasPiece() && end.Piece.Color == Color)
        return false;

    }
  }
}

