namespace TicTacToeKata;

public class Board
{
    private readonly List<Position> positions = new();
    public void CreateBoard(int boardSize)
    {
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                positions.Add(new Position
                {
                    x = i,
                    y = j,
                    symbol = string.Empty
                });
            }
        }
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