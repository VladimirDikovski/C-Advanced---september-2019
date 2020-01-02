using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            InputElements(matrix);
            FindSumOdDiagonals(matrix);
         
          
        }

        private static void FindSumOdDiagonals(int[,] matrix)
        {
            int sumOfPrimary = 0;
            int sumOfSecond = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {              
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumOfPrimary += matrix[row,col+row];
                    break;
                }
            }
            int index = 0;
            for (int row =matrix.GetLength(0)-1; row >=0; row--)
            {
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumOfSecond += matrix[row, col + index];
                    break;
                }
                index++;
            }

            Console.WriteLine(Math.Abs(sumOfPrimary-sumOfSecond));
        }

        private static void InputElements(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
