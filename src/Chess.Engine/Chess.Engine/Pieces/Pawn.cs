namespace Chess.Engine.Pieces
{
  public class Pawn : Piece
  {
    public Pawn(Color color) : base(color){}

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      if (!start.Position.IsValid() || !end.Position.IsValid())
        return false;

      if (end.Piece.Color == Color)
        return false;

      // If we are not capturing a piece, therefore moving straight, and there is no piece in front of us.
      if (start.Position.X == end.Position.X)
      {
        // can move 2
        if (start.Position.X == 1 && Color == Color.White || start.Position.X == 6 && Color == Color.Black) 
        { 
          
        }

        else
        {
          // can move 1
        }
      }

    }
  }
}
