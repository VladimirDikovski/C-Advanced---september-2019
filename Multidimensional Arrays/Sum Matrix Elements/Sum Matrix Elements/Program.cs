using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colsAndRows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = colsAndRows[0];
            int cols = colsAndRows[1];
            int[,] matrix = new int[rows, cols];
            AddElementsInMatrix(cols, rows, matrix, colsAndRows);
            PrintCountRowAndCol(rows, cols);
            PrintSumOfAllElements(matrix);

        }

        private static void PrintSumOfAllElements(int[,] matrix)
        {
            int sumOFelements = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sumOFelements += matrix[row, col];

                }
            }
            Console.WriteLine(sumOFelements);
        }

        private static void PrintCountRowAndCol(int rows, int cols)
        {
            Console.WriteLine(rows);
            Console.WriteLine(cols);
        }

        private static int[,] AddElementsInMatrix(int cols, int rows, int[,] matrix, int[] colsAndRows)
        {

            for (int row = 0; row <rows; row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            return matrix;
        }
    }
}
