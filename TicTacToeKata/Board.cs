namespace TicTacToeKata;

public class Board
{
    private readonly List<Position> positions = new();
    public void CreateBoard(int boardSize)
    {
        CreateBoardRows(boardSize);
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
        positions.Add(new Position
        {
            x = row,
            y = column,
            symbol = string.Empty
        });
    }

    public bool IsPositionTaken(int x, int y)
    {
        return !string.IsNullOrEmpty(positions.First(p => p.x == x && p.y == y).symbol);
    }

    public void TakePosition(int x, int y, string s)
    {
        positions.First(p => p.x == x && p.y == y).symbol = s;
    }
}