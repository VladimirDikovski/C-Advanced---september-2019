using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            InputMatrix(matrix, sizeOfMatrix);
            FindSumOfDiagonal(matrix);
            
            
        }

        private static void FindSumOfDiagonal(int[,] matrix)
        {
            int index = 0;
            int sumOfDiagonal = 0;
            for (int rol = matrix.GetLength(0)-1; rol>=0; rol--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumOfDiagonal += matrix[rol, col+index];
                    break;
                }
                index++;
            }

            Console.WriteLine(sumOfDiagonal);
        }

        private static int[,] InputMatrix(int[,] matrix, int sizeOfMatrix)
        {
            for (int row = 0; row <sizeOfMatrix; row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }


            return matrix;
        }
    }
}
