using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        public char[] CreateBoard()
        {
            char[] gameBoard = new char[10];
            for (int block = 1; block < gameBoard.Length; block++)
            {
                gameBoard[block] = ' ';
            }
            return gameBoard;
        }
    }
}
