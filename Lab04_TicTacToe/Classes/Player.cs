using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
        public string Name { get; set; }
        /// <summary>
        /// P1 is X and P2 will be O
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Flag to determine if it is the user's turn
        /// </summary>
        public bool IsTurn { get; set; }

        /// <summary>
        /// This method asks the player to pick a position on the board. The displayed numbers to choose from will be from 1-9 and correspond to an index in the rectangular game board array. This method is called in instance method TakeTurn currently located at the bottom of this file.
        /// </summary>
        /// <param name="board">an instance of the Board class</param>
        /// <returns>an instance of the Position class</returns>
        public Position GetPosition(Board board)
        {
            Position desiredCoordinate = null;
            while (desiredCoordinate is null)
            {
                Console.WriteLine("Please select a location");
                Int32.TryParse(Console.ReadLine(), out int position);
                desiredCoordinate = PositionForNumber(position);
            }
            return desiredCoordinate;

        }

        /// <summary>
        /// This method takes the user's input and turns it into a position instance. The position instance consists of two properties, row and column, which are assigned upon object instantiation in each switch case statement. This method is called in another instance TakeTurn ocated within this class.
        /// </summary>
        /// <param name="position">user input interger that corresponds to board game array</param>
        /// <returns>an instance of the Position class</returns>
        public static Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); // Top Left
                case 2: return new Position(0, 1); // Top Middle
                case 3: return new Position(0, 2); // Top Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(2, 0); // Bottom Left
                case 8: return new Position(2, 1); // Bottom Middle 
                case 9: return new Position(2, 2); // Bottom Right

                default: return null;
            }
        }

        /// <summary>
        /// This method is called in the Game class instance method Play. It is called repeatedly in a while loop until there is either a winner or a tie. The player will be asked to pick a position on the game board. The position is checked for whether or not it is already occupied. If it is not occupied, the existing num string is replaced with the player's marker.
        /// </summary>
        /// <param name="board">Board instance</param>
        public bool TakeTurn(Board board)
        {
            IsTurn = true;

            Console.WriteLine($"{Name} it is your turn");

            Position position = GetPosition(board);

            // _ indicates we will be ignoring that out int variable
            if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
            {
                board.GameBoard[position.Row, position.Column] = Marker;
                return true;
            }
            else
            {
                Console.WriteLine("This space is already occupied");
                return false;
            }
        }
    }
}
