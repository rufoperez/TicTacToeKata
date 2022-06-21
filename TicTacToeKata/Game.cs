namespace TicTacToeKata;

public class Game
{
    private string lastPlayer = string.Empty;

    public void Play(string s, int x, int y)
    {
        if (string.IsNullOrEmpty(lastPlayer) && !s.Equals("X"))
            throw new InvalidOperationException("Player X must start the game");
        if (lastPlayer.Equals(s))
            throw new InvalidOperationException("Invalid player");
        
        lastPlayer = s;
    }
}