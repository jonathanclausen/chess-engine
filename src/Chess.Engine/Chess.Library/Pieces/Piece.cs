namespace Chess.Library.Pieces
{
  public abstract class Piece
  {
    private Color _color;
    private bool _killed;

    public Piece(Color color)
    {
      _color = color;
    }
    public Color Color { get { return _color; } set { _color = value; } }
    public bool Killed { get { return _killed;} set { _killed = value; } }

    public bool IsKilled() => _killed;
    public Color GetColor() => _color;

    public abstract bool CanMove(Board board, Spot start, Spot end);
  }
}
