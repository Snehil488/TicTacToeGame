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
            char computerLetter = ticTacToe.getCompLetter(userLetter);
            Console.WriteLine("Your Letter :"+userLetter);
            Console.WriteLine("Computer's Letter :"+computerLetter);
            ticTacToe.showBoard(gameBoard);
        }
    }
}
