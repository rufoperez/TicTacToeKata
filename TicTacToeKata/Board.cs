namespace TicTacToeKata;

public class Board
{
    private readonly List<Cell> cells = new();

    public List<Cell> Cells
    {
        get { return cells; }
    }

    public void CreateBoard(int boardSize)
    {
        CreateBoardRows(boardSize);
    }

    public bool IsPositionTaken(Position position)
    {
        return !string.IsNullOrEmpty(cells.First(p => p.Position.Equals(position)).GetSymbol());
    }

    public void TakePosition(string s, Position position)
    {
        cells.First(p => p.Position.Equals(position)).TakeCell(s);
    }

    private void CreateBoardRows(int boardSize)
    {
        for (int row = 0; row < boardSize; row++)
        {
            CreateBoardColumns(boardSize, row);
        }
    }

    private void CreateBoardColumns(int boardSize, int row)
    {
        for (int column = 0; column < boardSize; column++)
        {
            CreateNewPosition(row, column);
        }
    }

    private void CreateNewPosition(int row, int column)
    {
        cells.Add(Cell.CreateInstance(row, column));
    }
}