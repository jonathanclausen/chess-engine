using Chess.Library;
using Chess.Library.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chess.Engine
{
  public class Printer
  {
    public Dictionary<Type, string> PieceUI = new Dictionary<Type, string>()
    {
      {typeof(Rook), "R" },
      {typeof(Knight), "N" },
      {typeof(Bishop), "B" },
      {typeof(Queen), "Q" },
      {typeof(King), "K" },
      {typeof(Pawn), "P" }
    };

    public Dictionary<Color, string> ColorUI = new Dictionary<Color, string>()
    {
      { Color.White, "w" },
      { Color.Black, "b" }
    };

    public void PrintBoard(Board board) 
    {
      string separator = "-----------------------------------------";
      int uBound0 = board.Squares.GetUpperBound(0);
      int uBound1 = board.Squares.GetUpperBound(1);
      for (int i = 0; i <= uBound0; i++)
      {
        Console.WriteLine(separator);
        for (int j = 0; j <= uBound1; j++)
        {
          string row = "";
          row += "| ";
          Spot spot = board.Squares[j,i];
          if (spot.HasPiece())
            row += $"{ColorUI[spot.Piece.Color]}{PieceUI[spot.Piece.GetType()]}";
          else
            row += "  ";
          row += "| ";
          Console.WriteLine(row);
        }
      }
    }
  }
}
