using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        //2D Array, the first cloumn is the position of the board 
        // Second cloumn is 0 = empty, 1 = X, and 2 = O 

        //How the array will look
        // 0| 1| 2|
        // 3| 4| 5|
        // 6| 7| 8|

        public int[,] CreateBoard()
        {
            int[,] boardArray = new int[9, 2]
            {
                {0, 0}, {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0}, {7, 0}, {8, 0}
            };
            return boardArray;
        }
        public string CurrentPlayer(int turn, string playerOne, string playerTwo)
        {
            //Assuming thaat player one will always go first, 
            //they will be x and the first turn will be player one's turn
            if (turn % 2 == 0)
            {
                return playerTwo;
            }
            else
            {
                return playerOne;
            }
        }
        public string ChangePlayer(string playerOne, string playerTwo, string currentPlayer)
        {
            //changes the current player to either player one or to player two
            if (currentPlayer == playerOne)
            {
                return playerTwo;
            }
            else
            {
                return playerOne;
            }

        }
        public void MakeMove(string playerOne, string playerTwo, string currentPlayer, int[,] boardArray, int position)
        {
            //Positions order
            // 0| 1| 2|
            // 3| 4| 5|
            // 6| 7| 8|

            //Assume PLayer One is X and Player Two is O
            //Where X = 1 and O = 2
            //SpaceInUse method would be called before 
            //MakeMove to check if a position is empty or not

            if (currentPlayer == playerOne)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[position, j] = 1;
                }
            }
            else
            {
                for (int k = 0; k < boardArray.GetLength(1); k++)
                {
                    boardArray[position, k] = 2;
                }
            }
        }
        public Boolean SpaceInUse(int[,] boardArray, int position)
        {
            //Checks if a position is in use 
            for (int j = 0; j < boardArray.GetLength(1); j++)
            {
                if (boardArray[position, j] != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
