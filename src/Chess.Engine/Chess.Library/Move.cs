using System;
using Chess.Library.Pieces;

namespace Chess.Library
{
  public class Move
  {
    private Spot _start { get; set; }
    private Spot _end { get; set; }
    private Piece _piece { get; set; }
    
    public Move(Piece piece, Spot start, Spot end)
    {
      _start = start;
      _end = end;
      _piece = piece;
    }

    public bool CanMove(Board board)
    {
      if (!(_start.Position.IsValid() && _end.Position.IsValid()))
        return false;
      return _piece.CanMove(board, _start, _end);
    }

  }
}

