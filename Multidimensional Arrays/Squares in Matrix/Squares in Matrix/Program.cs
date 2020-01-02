using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            char[,] matrix = new char[rows, cols];
            InputElements(matrix);
            Find2X2EqualElements(matrix);
            
        }

        private static void Find2X2EqualElements(char[,] matrix)
        {
            int countTime = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1] && matrix[row + 1, col]==matrix[row,col])
                    {
                        countTime++;
                    }
                }
            }
            Console.WriteLine(countTime);
        }

        private static void InputElements(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] Elements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Elements[col];
                }
            }
            
        }
    }
}
