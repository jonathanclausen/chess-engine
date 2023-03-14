using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Library.Pieces
{
  public  class Rook : Piece
  {
    public Rook(Color color) : base(color) { }

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      // can only move straight
      bool movingOnX = end.Position.X != start.Position.X;
      if (end.Position.X != start.Position.X && end.Position.Y != start.Position.Y) 
        return false;
      if (end.HasPiece() && end.Piece.Color == Color)
        return false;
      
      if (movingOnX)
      {
        Spot spot = board.GetSpot(new Position(start.Position.X + 1, start.Position.Y));
        while (spot.Position.X != end.Position.X)
        {
          if (spot.HasPiece())
            return false;
          spot = board.GetSpot(new Position(start.Position.X + 1, start.Position.Y));
        }
      }
      else
      {
        Spot spot = board.GetSpot(new Position(start.Position.X, start.Position.Y + 1));
        while (spot.Position.X != end.Position.X)
        {
          if (spot.HasPiece())
            return false;
          spot = board.GetSpot(new Position(start.Position.X, start.Position.Y + 1));
        }
      }
      return true;
    }
  }
}
