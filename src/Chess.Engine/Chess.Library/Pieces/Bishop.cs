using System;
namespace Chess.Library.Pieces
{
  public class Bishop : Piece
  {
    public Bishop(Color color) : base(color) { }

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      var distX = Math.Abs(end.Position.X - start.Position.X);
      var distY = Math.Abs(end.Position.Y - start.Position.Y);

      if (distX != distY)
        return false; // can only move diagonal
      if (end.HasPiece() && end.Piece.Color == Color)
        return false; 
      
      return true;
    }
  }
}

