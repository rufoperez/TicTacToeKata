namespace TicTacToeKata;

public class Cell
{
    private string symbol;
    private Position position;

    public Position Position => position;

    private Cell(int row, int column)
    {
        position = Position.Create(row, column);
        symbol = string.Empty;
    }

    public static Cell CreateInstance(int row, int column)
    {
        return new Cell(row, column);
    }

    public void TakeCell(string s)
    {
        symbol = s;
    }

    public string GetSymbol()
    {
        return symbol;
    }
}