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
        public char ChooseLetter()
        {
            while (true)
            {
                Console.WriteLine("Choose a Letter among 'X' or 'O' ");
                char userLetter = (Console.ReadLine()).ToUpper()[0];
                if (userLetter == 'X' || userLetter == 'O')
                {
                    return userLetter;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
    }
}
