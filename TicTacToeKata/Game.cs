namespace TicTacToeKata;

public class Game
{
    private string lastPlayer = string.Empty;
    private readonly Board board = new();

    public Game()
    {
        board.CreateBoard(3);
    }

    public void Play(string s, int x, int y)
    {
        if (string.IsNullOrEmpty(lastPlayer) && !s.Equals("X"))
            throw new InvalidOperationException("Player X must start the game");
        if (lastPlayer.Equals(s))
            throw new InvalidOperationException("Invalid player");
        if(board.IsPositionTaken(x, y))
            throw new InvalidOperationException("Invalid position");

        lastPlayer = s;
        board.TakePosition(x, y, s);
    }
}