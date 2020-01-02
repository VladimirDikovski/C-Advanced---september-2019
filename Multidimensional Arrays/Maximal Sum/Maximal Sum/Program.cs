using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            int[,] matrix = new int[rows, cols];
            InputElements(matrix);
            SumOF3x3Matrix(matrix);
            
        }

        private static void SumOF3x3Matrix(int[,] matrix)
        {
            int maxValue = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
          
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                   int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                           matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxValue)
                    {
                        maxValue = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                 
                }
               
            }
            PrintResult(maxRow, maxCol, maxValue,matrix);
          
        }

        private static void PrintResult(int maxRow, int maxCol, int maxValue,int[,]matrix)
        {
            Console.WriteLine($"Sum = {maxValue}");
            for (int rol = maxRow; rol <= maxRow+2; rol++)
            {
                for (int col = maxCol; col <= maxCol+2; col++)
                {
                    Console.Write(matrix[rol,col]+" ");
                }
                Console.WriteLine();
            }
        }

        private static void InputElements(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
