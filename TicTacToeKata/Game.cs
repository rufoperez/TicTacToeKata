namespace TicTacToeKata;

public class Game
{
    private string lastPlayer = string.Empty;
    private List<Position> board = new List<Position>();

    public Game()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board.Add(new Position
                {
                    x = i,
                    y = j,
                    symbol = string.Empty
                });
            }
        }
    }

    public void Play(string s, int x, int y)
    {
        if (string.IsNullOrEmpty(lastPlayer) && !s.Equals("X"))
            throw new InvalidOperationException("Player X must start the game");
        if (lastPlayer.Equals(s))
            throw new InvalidOperationException("Invalid player");
        if(board.Any(p => p.x == x && p.y == y && !string.IsNullOrEmpty(p.symbol)))
            throw new InvalidOperationException("Invalid position");

        lastPlayer = s;
        board.First(p => p.x == x && p.y == y).symbol = s;
    }
}

public class Position
{
    public int x;
    public int y;
    public string symbol;
}