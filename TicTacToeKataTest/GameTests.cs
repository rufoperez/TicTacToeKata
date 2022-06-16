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
            Action act = () => game.Play("O", 0, 0);

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Player X must start the game");
        }

        [Test]
        public void no_winner_when_player_X_plays_first()
        {
            var winner = game.Play("X", 0, 0);

            winner.Should().BeEmpty();
        }

    }
}