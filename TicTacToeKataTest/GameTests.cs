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
        public void error_when_player_X_plays_twice()
        {
            game.Play("X", 0, 0);

            Action act = () => game.Play("X", 0, 0);

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Invalid player");
        }

        [Test]
        public void error_when_player_O_plays_twice()
        {
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);

            Action act = () => game.Play("O", 0, 2);

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Invalid player");
        }

        [Test]
        public void error_when_player_plays_in_previous_position()
        {
            game.Play("X", 0, 0);

            Action act = () => game.Play("Y", 0, 0);

            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Invalid position");
        }

        [Test]
        public void player_X_is_winner_if_top_row_is_full()
        {
            game.Play("X", 0, 0);
            game.Play("O", 1, 0);
            game.Play("X", 0, 1);
            game.Play("O", 1, 1);
            game.Play("X", 0, 2);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_O_is_winner_if_top_row_is_full()
        {
            game.Play("X", 2, 2);
            game.Play("O", 0, 0);
            game.Play("X", 1, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 1);
            game.Play("O", 0, 2);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_X_is_winner_if_mid_row_is_full()
        {
            game.Play("X", 1, 0);
            game.Play("O", 0, 0);
            game.Play("X", 1, 1);
            game.Play("O", 0, 1);
            game.Play("X", 1, 2);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_O_is_winner_if_mid_row_is_full()
        {
            game.Play("X", 0, 0);
            game.Play("O", 1, 0);
            game.Play("X", 2, 0);
            game.Play("O", 1, 1);
            game.Play("X", 2, 1);
            game.Play("O", 1, 2);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_X_is_winner_if_bottom_row_is_full()
        {
            game.Play("X", 2, 0);
            game.Play("O", 0, 0);
            game.Play("X", 2, 1);
            game.Play("O", 0, 1);
            game.Play("X", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_O_is_winner_if_bottom_row_is_full()
        {
            game.Play("X", 0, 0);
            game.Play("O", 2, 0);
            game.Play("X", 1, 0);
            game.Play("O", 2, 1);
            game.Play("X", 1, 1);
            game.Play("O", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_X_is_winner_if_first_column_is_full()
        {
            game.Play("X", 0, 0);
            game.Play("O", 1, 1);
            game.Play("X", 1, 0);
            game.Play("O", 1, 2);
            game.Play("X", 2, 0);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_X_is_winner_if_second_column_is_full()
        {
            game.Play("X", 0, 1);
            game.Play("O", 1, 0);
            game.Play("X", 1, 1);
            game.Play("O", 1, 2);
            game.Play("X", 2, 1);

            var winner = game.Winner();

            winner.Should().Be("X");
        }
        [Test]
        public void player_X_is_winner_if_third_column_is_full()
        {
            game.Play("X", 0, 2);
            game.Play("O", 1, 0);
            game.Play("X", 1, 2);
            game.Play("O", 1, 1);
            game.Play("X", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_Y_is_winner_if_first_column_is_full()
        {
            game.Play("X", 1, 1);
            game.Play("O", 0, 0);
            game.Play("X", 1, 2);
            game.Play("O", 1, 0);
            game.Play("X", 2, 1);
            game.Play("O", 2, 0);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_Y_is_winner_if_second_column_is_full()
        {
            game.Play("X", 1, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 2);
            game.Play("O", 1, 1);
            game.Play("X", 2, 0);
            game.Play("O", 2, 1);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_Y_is_winner_if_third_column_is_full()
        {
            game.Play("X", 1, 0);
            game.Play("O", 0, 2);
            game.Play("X", 1, 1);
            game.Play("O", 1, 2);
            game.Play("X", 2, 0);
            game.Play("O", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_X_is_winner_if_first_diagonal_is_full()
        {
            game.Play("X", 0, 0);
            game.Play("O", 1, 0);
            game.Play("X", 1, 1);
            game.Play("O", 1, 2);
            game.Play("X", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_Y_is_winner_if_first_diagonal_is_full()
        {
            game.Play("X", 1, 0);
            game.Play("O", 0, 0);
            game.Play("X", 0, 1);
            game.Play("O", 1, 1);
            game.Play("X", 1, 2);
            game.Play("O", 2, 2);

            var winner = game.Winner();

            winner.Should().Be("O");
        }

        [Test]
        public void player_X_is_winner_if_second_diagonal_is_full()
        {
            game.Play("X", 0, 2);
            game.Play("O", 1, 0);
            game.Play("X", 1, 1);
            game.Play("O", 1, 2);
            game.Play("X", 2, 0);

            var winner = game.Winner();

            winner.Should().Be("X");
        }

        [Test]
        public void player_Y_is_winner_if_second_diagonal_is_full()
        {
            game.Play("X", 1, 0);
            game.Play("O", 0, 2);
            game.Play("X", 0, 1);
            game.Play("O", 1, 1);
            game.Play("X", 1, 2);
            game.Play("O", 2, 0);

            var winner = game.Winner();

            winner.Should().Be("O");
        }
    }
}