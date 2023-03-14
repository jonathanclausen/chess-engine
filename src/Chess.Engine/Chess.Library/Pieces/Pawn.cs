namespace Chess.Library.Pieces
{
  public class Pawn : Piece
  {
    public Pawn(Color color) : base(color){}

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      // cannot move backwards
      if (Color == Color.White && end.Position.Y <= start.Position.Y)
        return false;
      else if (Color == Color.Black && end.Position.Y >= start.Position.Y)

      // Cannot move to square with same colored piece
      if (end.Piece?.Color == Color)
        return false;

      // If we are not capturing a piece, therefore moving straight, and there is no piece in front of us.
      if (start.Position.X == end.Position.X)
      {
        // can move 2
        var delta = Math.Abs(end.Position.Y - start.Position.Y);
        if (start.Position.Y == 1 && Color == Color.White || start.Position.Y == 6 && Color == Color.Black)
        {
          if (delta <= 2)
            return true;
        }
        else
        {
          // can move 1
          if (delta == 1)
            return true;
        }
      }
      bool moveIsOneDiagonal =
        Math.Abs(end.Position.X - start.Position.X) == 1
        && Math.Abs(end.Position.Y - start.Position.Y) == 1;
      if (moveIsOneDiagonal)
      {
        if (end.HasPiece() && end.Piece.Color != Color)
          return true;
      }
      return false;
    }
  }
}
