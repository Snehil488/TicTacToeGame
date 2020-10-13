using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        private const int HEAD = 0;
        private const int TAIL = 1;
        private string[] Players = { "USER", "COMPUTER" };
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
                if (index > 0 && index < 10)
                {
                    if(IsSpaceFree(gameBoard, index))
                    {
                        gameBoard[index] = userLetter;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Try Again.");
                }
            }
        }
        public bool IsSpaceFree(char[] gameBoard, int index)
        {
            if (gameBoard[index] == ' ')
                return true;
            else
                return false;
        }
        public string DoAToss()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            string winner="";
            switch (result)
            {
                case HEAD :
                    Console.WriteLine("User Won The Toss.");
                    winner = Players[HEAD];
                    break;
                case TAIL :
                    Console.WriteLine("Computer Won The Toss");
                    winner = Players[TAIL];
                    break;
            }
            return winner;
        }
    }
}
