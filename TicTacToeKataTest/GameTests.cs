using FluentAssertions;
using TicTacToeKata;

namespace TicTacToeKataTest
{
    public class GameTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void error_when_player_O_plays_first()
        {
            Action act = () => game.Play("O");

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Player X must start the game");
        }

        [Test]
        public void error_when_player_X_plays_twice()
        {
            game.Play("X");

            Action act = () => game.Play("X");

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Invalid player");
        }

        [Test]
        public void error_when_player_O_plays_twice()
        {
            game.Play("X");

            Action act = () => game.Play("X");

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Invalid player");
        }
    }
}