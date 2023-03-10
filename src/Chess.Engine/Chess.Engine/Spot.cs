using Chess.Engine.Pieces;

namespace Chess.Engine
{
  public class Spot
  {
    private Piece _piece;
    private Position _position;

    public Spot(Piece piece, Position position)
    {
      _piece = piece;
      _position = position;
    }

    public Piece Piece
    {
      get { return _piece; }
      set { _piece = value; }
    }

    public Position Position
    {
      get { return _position; }
      set { _position = value; }
    }


  }
}
