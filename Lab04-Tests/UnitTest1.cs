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

        /// <summary>
        /// Instantiate new objects of each class in order to have test values to pass into methods
        /// </summary>
        public Board board = new Board();
        public static Player p1 = new Player { Name = "Test", Marker = "X", IsTurn = true };
        public static Player p2 = new Player { Name = "Player", Marker = "O", IsTurn = false };
        public Game game = new Game(p1, p2);

        /// <summary>
        /// Check that the board is being created with proper values
        /// </summary>
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

        /// <summary>
        /// Test when no one wins
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(false)]
        public void CheckWinner1(bool expected)
        {
            board.GameBoard = new string[,] { { "1", "O", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

            Assert.Equal(expected, game.CheckForWinner(board));
        }

        /// <summary>
        /// Test where X is the winner
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(true)]
        public void CheckWinner2(bool expected)
        {
            game.Board = board;
            board.GameBoard = new string[,] { { "X", "X", "X" }, { "4", "5", "6" }, { "7", "8", "9" } };

            Assert.Equal(expected, game.CheckForWinner(board));
        }

        /// <summary>
        /// Test when O is the winner
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(true)]
        public void CheckWinner3(bool expected)
        {
            game.Board = board;
            board.GameBoard = new string[,] { { "1", "X", "O" }, { "4", "X", "O" }, { "7", "8", "O" } };

            Assert.Equal(expected, game.CheckForWinner(board));
        }

        // Test that there is a switch in players between turns
        /// <summary>
        /// p1 is the starting player because its IsTurn property = true.
        /// For this test to pass, p2.IsTurn should be true and p1.IsTurn should be false.
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(true)]
        public void SwitchPlayers(bool expected)
        {
            game.SwitchPlayer();
            bool switchedPlayers = p1.IsTurn == false && p2.IsTurn == true;

            Assert.Equal(expected, switchedPlayers);
        }
    }
}
