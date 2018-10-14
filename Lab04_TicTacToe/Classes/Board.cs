using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
        /// <summary>
        /// Tic Tac Toe Gameboard states. This is an instance field. I can manipulate it within my class, but it's not a property because I don't want to be able to manipulate this data outside of the class itself.
        /// </summary>
        public string[,] GameBoard { get; set; } =
        new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        /// <summary>
        /// This prints the GameBoard property to the console.
        /// </summary>
        public void DisplayBoard()
        {

            //TODO: Output the board to the console
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                Console.WriteLine($"|{GameBoard[i, 0]}||{GameBoard[i, 1]}||{ GameBoard[i, 2]}|" + "\t");
            }
        }
    }
}
