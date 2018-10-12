using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Board board = new Board();
            //board.DisplayBoard();
            //Console.ReadLine();

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
        }
    }
}
