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
        public char getCompLetter(char userLetter)
        {
            char computerLetter;
            if (userLetter == 'X')
            {
                computerLetter = 'O';
            }
            else
            {
                computerLetter = 'X';
            }
            return computerLetter;
        }
        public void showBoard(char[] gameBoard)
        {
            Console.WriteLine(gameBoard[1]+" | "+gameBoard[2]+" | "+gameBoard[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(gameBoard[4]+" | "+gameBoard[5]+" | "+gameBoard[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(gameBoard[7]+" | "+gameBoard[8]+" | "+gameBoard[9]);
        }
        public void MakeYourMove(char[] gameBoard, char userLetter)
        {
            Console.WriteLine("Enter Index of Desired Position :");
            while (true)
            {
                int index = Convert.ToInt32(Console.ReadLine());
                if (gameBoard[index] == ' ')
                {
                    gameBoard[index] = userLetter;
                    break;
                }
                else
                {
                    Console.WriteLine("Already Taken, Choose different Position");
                }
            }
        }
    }
}
