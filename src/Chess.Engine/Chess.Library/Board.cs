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
    private Spot[,] _squares;
    private List<Piece> _pieces;

    public Board()
    {
      Initialize();
    }

    public void Initialize()
    {
      _pieces= new List<Piece>();
      _squares = new Spot[8,8];
      InitializeSquares();
      SetupPieces();
    }
    private void InitializeSquares()
    {
      for (int i = 0; i < 8; i++)
      {
        for (int j = 0; j < 8; j++)
        {
          _squares[i,j] = new Spot(null, new Position(i,j));
        }
      }
    }
    public Spot GetSquare(Position position)
    {
      if (position.IsValid())
        return _squares[position.X,position.Y];
      else
        throw new IndexOutOfRangeException($"Position is outside of the board: x={position.X}, y={position.Y}");
    }

    public Spot GetSpot(Position position)
    {
      return _squares[position.X,position.Y];
    }
    public void SetupPieces()
    {
      InitializeWhite<Rook>(new Position(0, 0));
      //InitializeWhite<Knight>(new Position(1, 0));
      InitializeWhite<Bishop>(new Position(2, 0));
      //InitializeWhite<Queen>(new Position(3, 0));
      //InitializeWhite<King>(new Position(4, 0));
      InitializeWhite<Bishop>(new Position(5, 0));
      //InitializeWhite<Knight>(new Position(6, 0));
      InitializeWhite<Rook>(new Position(7, 0));
      for (int i = 0; i< 8; i++)
        InitializeWhite<Pawn>(new Position(i, 1));

      InitializeBlack<Rook>(new Position(0, 7));
      //InitializeBlack<Knight>(new Position(1, 7));
      InitializeBlack<Bishop>(new Position(2, 7));
      //InitializeBlack<Queen>(new Position(3, 7));
      //InitializeBlack<King>(new Position(4, 7));
      InitializeBlack<Bishop>(new Position(5, 7));
      //InitializeBlack<Knight>(new Position(6, 7));
      InitializeBlack<Rook>(new Position(7, 7));
      for (int i = 0; i < 8; i++)
        InitializeBlack<Pawn>(new Position(i, 6));
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
      _squares[position.X,position.Y].Piece = piece;
    }
  }
}
