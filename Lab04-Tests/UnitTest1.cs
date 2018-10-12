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

        Board board = new Board();
        //board.GameBoard = new string[,] { { "X", "X", "X" }, { "4", "5", "6" }, { "7", "8", "9" } };
        public static string[,] gameboard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

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


    }
}
