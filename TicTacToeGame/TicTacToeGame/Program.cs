﻿using System;

namespace TicTacToeGame
{
    internal class Program
    {
        static char[] myArray = { '1', '2', '3', '4', '5', '6', '7' , '8', '9'};
        static int player = 1;
        static int mamekAMove;
        static int win = 0;
        //if win 1 = a player won
        //if win 0 = nobody won
        //if win -1 = draw

        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Display();

            do
            {
                Console.Clear();
            }
            while (win != 1 && win != -1);

            if ( win == 1)
            {
                Console.WriteLine("Player {0} has won ", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Its a draw");
            }

;        }

        public static void Display()
        {

            Console.WriteLine("Welcome to Tic Tac Toe");
          Console.WriteLine("\n");
            Console.WriteLine(" {0}   |    {1}    |     {2} ",  myArray[0], myArray[1], myArray[2]);
            Console.WriteLine("_____|_________|__________      ");
            Console.WriteLine("     |         |       ");
            Console.WriteLine(" {0}   |    {1}    |     {2} ", myArray[3], myArray[4], myArray[5]);
            Console.WriteLine("_____|_________|__________      ");
            Console.WriteLine("     |         |       ");
            Console.WriteLine(" {0}   |    {1}    |     {2} ", myArray[6], myArray[7], myArray[8]);
        }
        private static int Win()
        {
            //horizontal wins
            if ((myArray[0] == myArray[1] && myArray[1]==  myArray[2] )|| (myArray[3] == myArray[4] && myArray[4] == myArray[5]) ||
                (myArray[6] == myArray[7] && myArray[7] == myArray[8]))
            {
                return 1;
            }
            //vertical
            else if ((myArray[0] == myArray[3] && myArray[3] == myArray[6]) || (myArray[1] == myArray[4] && myArray[4] == myArray[7]) ||
                (myArray[2] == myArray[5] && myArray[5] == myArray[8]))
            {
                return 1;
            }
            else if ((myArray[0] == myArray[4] && myArray[4] == myArray[8]) || (myArray[2] == myArray[4] && myArray[4] == myArray[6]))
            {
                return 1;
            }
            //draw
            else if (myArray[0] != '1' && myArray[1]!= '2' && myArray[2]!= '3' && myArray[3]!= '4' && myArray[4]!= '5' &&
                myArray[5]!= '6' && myArray[6]!= '7' && myArray[7]!= '8' && myArray[8]!= '9')
            {
                return -1;
            }
            //nobody wins
            else
            {
                return 0;
            }
        }
    }
}