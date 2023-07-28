using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Library.Pieces
{
  public  class King : Piece
  {
    public King(Color color) : base(color) { }

    public override bool CanMove(Board board, Spot start, Spot end)
    {
      return true;
    }
  }
}
