using FluentAssertions;

namespace TicTacToeKataTest
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void error_when_player_O_plays_first()
        {
            Game game = new Game();
            Action act = () => game.Play("O", 0, 0);

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Player X must start the game");
        }
    }

    public class Game
    {
        public void Play(string s, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}