using Chess.Library.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Library
{
  public class Board
  {
    private Spot[][] _squares;
    private List<Piece> _pieces;

    public Board()
    {
      Initialize();
    }

    public void Initialize()
    {
      _squares = new Spot[8][];
      _pieces= new List<Piece>();
      SetupPieces();
    }

    public Spot GetSquare(Position position)
    {
      if (position.IsValid())
        return _squares[position.X][position.Y];
      else
        throw new IndexOutOfRangeException($"Position is outside of the board: x={position.X}, y={position.Y}");
    }

    public Spot GetSpot(Position position)
    {
      return _squares[position.X][position.Y];
    }
    public void SetupPieces()
    {
      //_squares[0][0] = new Spot()
    }

    private T InitializeWhite<T>(Position position) where T : Piece
    {
      T piece = Activator.CreateInstance(typeof(T), Color.White) as T;
      SetPiece(piece, position);
      return piece;
    }
    private T InitializeBlack<T>(Position position) where T : Piece
    {
      T piece = Activator.CreateInstance(typeof(T), Color.Black) as T;
      SetPiece(piece, position);
      return piece;
    }
    private void SetPiece(Piece piece, Position position)
    {
      Spot spot = new Spot(piece, position);
      _squares[position.X][position.Y] = spot;
    }
  }
}
