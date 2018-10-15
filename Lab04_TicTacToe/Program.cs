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
                IsTurn = true,
                Marker = "X"
            };

            Player p2 = new Player
            {
                IsTurn = false,
                Marker = "O"
            };

            Console.WriteLine("Player 1, What's your name?");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Player 2, What's your name?");
            p2.Name = Console.ReadLine();

            // Create the Game
            Game game = new Game(p1, p2);

            // Play the Game
            // Output the winner
            Console.WriteLine(game.Play().Name);
            Board board = new Board();
        }
    }
}
