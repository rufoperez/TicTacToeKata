namespace TicTacToeKata;

public class Game
{
    private string lastPlayer = string.Empty;
    private readonly Board board = new();
    private const int BOARD_SIZE = 3;

    public Game()
    {
        board.CreateBoard(BOARD_SIZE);
    }

    public void Play(string s, int x, int y)
    {
        Position position = Position.Create(x, y);

        if (string.IsNullOrEmpty(lastPlayer) && !s.Equals("X"))
            throw new InvalidOperationException("Player X must start the game");
        if (lastPlayer.Equals(s))
            throw new InvalidOperationException("Invalid player");
        if(board.IsPositionTaken(position))
            throw new InvalidOperationException("Invalid position");

        lastPlayer = s;
        board.TakePosition(s, position);
    }

    public string Winner()
    {
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            var firstCell = Position.Create(i, 0);
            var middleCell = Position.Create(i, 1);
            var lastCell = Position.Create(i, 2);

            if (board.IsPositionTaken(firstCell)
                && (board.SymbolAtPosition(firstCell) == board.SymbolAtPosition(middleCell))
                && (board.SymbolAtPosition(lastCell) == board.SymbolAtPosition(middleCell)))
            {
                return board.SymbolAtPosition(firstCell);
            }
        }

        for (int i = 0; i < BOARD_SIZE; i++)
        {
            var firstCell = Position.Create(0, i);
            var middleCell = Position.Create(1, i);
            var lastCell = Position.Create(2, i);

            if (board.IsPositionTaken(firstCell)
                && (board.SymbolAtPosition(firstCell) == board.SymbolAtPosition(middleCell))
                && (board.SymbolAtPosition(lastCell) == board.SymbolAtPosition(middleCell)))
            {
                return board.SymbolAtPosition(firstCell);
            }
        }

        return string.Empty;
    }
}