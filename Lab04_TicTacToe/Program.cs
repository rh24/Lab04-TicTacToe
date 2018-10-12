using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.DisplayBoard();
            Console.ReadLine();
        }

        static void PlayGame()
        {
            // TODO: Instantiate your players
            Player p1 = new Player
            {
                Name = "X",
                IsTurn = true
            };

            Player p2 = new Player
            {
                Name = "O",
                IsTurn = false
            };

            // Create the Game
            Game game = new Game(p1, p2);

            // Play the Game
            // Output the winner
            Console.WriteLine(game.Play());
        }
    }
}
