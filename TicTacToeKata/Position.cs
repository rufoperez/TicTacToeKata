namespace TicTacToeKata;

public class Position
{
    private readonly int row;
    private readonly int column;

    private Position(int row, int column)
    {
        this.row = row;
        this.column = column;
    }

    public static Position Create(int row, int column)
    {
        return new Position(row, column);
    }

    public override int GetHashCode()
    {
        return row.GetHashCode() + column.GetHashCode() * 17;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (ReferenceEquals(obj, this))
            return false;

        if (obj.GetType() != this.GetType())
            return false;

        var position = obj as Position;

        return row == position.row
               && column == position.column;
    }
}