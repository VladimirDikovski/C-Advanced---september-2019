using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            char[,] snakeWay = new char[rows,cols];
            InputElements(snakeWay);
            PrintTheMatrix(snakeWay);

        }

        private static void PrintTheMatrix(char[,] snakeWay)
        {
            for (int row = 0; row < snakeWay.GetLength(0); row++)
            {
                for (int col = 0; col < snakeWay.GetLength(1); col++)
                {
                    Console.Write(snakeWay[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void InputElements(char[,] shakeWay)
        {
            string snakeName = Console.ReadLine();
            int counter = 0;
            for (int row = 0;row < shakeWay.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < shakeWay.GetLength(1); col++)
                    {
                        shakeWay[row, col] = snakeName[counter];
                        counter++;
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = shakeWay.GetLength(1)-1; col >=0; col--)
                    {
                        shakeWay[row, col] = snakeName[counter];
                        counter++;
                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
              
            }
        }
    }
}
