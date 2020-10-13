using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToe = new TicTacToeGame();
            char[] gameBoard = ticTacToe.CreateBoard();
            char userLetter = ticTacToe.ChooseLetter();
            char computerLetter;
            if(userLetter == 'X')
            {
                computerLetter = 'O';
            }
            else
            {
                computerLetter = 'X';
            }
        }
    }
}
