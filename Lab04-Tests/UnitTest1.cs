using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace Lab04_Tests
{
    public class UnitTest1
    {
        /*
            Given a game board, Test for winners (at least 3)
            Test that there is a switch in players between turns
            Confirm that the position the player inputs correlates to the correct index of the array
            One other “unique” test of your own
         */

        public Board board = new Board();
        public static Player p1 = new Player { Name = "Test", Marker = "X", IsTurn = true };
        public static Player p2 = new Player { Name = "Player", Marker = "O", IsTurn = false };
        public Game game = new Game(p1, p2);

        [Fact]
        public void DisplayBoard()
        {
            Assert.Equal(new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            }, board.GameBoard);
        }

        [Theory]
        [InlineData(false)]
        public void CheckWinner(bool expected)
        {
            board.GameBoard = new string[,] { { "X", "X", "X" }, { "4", "5", "6" }, { "7", "8", "9" } };

            Assert.Equal(expected, game.CheckForWinner(board));
        }
    }
}
