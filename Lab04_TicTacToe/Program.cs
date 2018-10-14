using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            // TODO: Instantiate your players
            Player p1 = new Player
            {
                Name = "Rebecca",
                IsTurn = true,
                Marker = "X"
            };

            Player p2 = new Player
            {
                Name = "Wen",
                IsTurn = false,
                Marker = "O"
            };

            // Create the Game
            Game game = new Game(p1, p2);

            // Play the Game
            // Output the winner
            Console.WriteLine(game.Play().Name);
            Board board = new Board();
            board.GameBoard = new string[,] { { "X", "X", "X" }, { "4", "5", "6" }, { "7", "8", "9" } };
            Console.WriteLine(game.CheckForWinner(board));
        }
    }
}
