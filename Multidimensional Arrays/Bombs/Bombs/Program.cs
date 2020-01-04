using System;
using System.Linq;
namespace Bombs
{
    class Program
    {
        static int[,] matrix;
        static int currentbombRow;
        static int currentBombCol;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];
            InputElements();
            BombsExplosion();
            PrintAliveCells();
        }
        private static void PrintAliveCells()
        {
            int sum = 0;
            int countAliveCells = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {             
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                        countAliveCells++;
                    }              
                }
            }          
                Console.WriteLine($"Alive cells: {countAliveCells}");
                Console.WriteLine($"Sum: {sum}");
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }           
        }
        private static void BombsExplosion()
        {
            int[] bombs = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(int.Parse).ToArray();

            for (int i = 0; i < bombs.Length / 2; i++)
            {
                currentbombRow = bombs[i + i];
                currentBombCol = bombs[i + i + 1];
                if (matrix[currentbombRow, currentBombCol] > 0)
                {
                if (isvalidCordinates(-1, 0))
                {
                    matrix[currentbombRow - 1, currentBombCol] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(-1, +1))
                {
                    matrix[currentbombRow - 1, currentBombCol + 1] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(-1, -1))
                {
                    matrix[currentbombRow - 1, currentBombCol - 1] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(0, -1))
                {
                    matrix[currentbombRow, currentBombCol - 1] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(0, +1))
                {
                    matrix[currentbombRow, currentBombCol + 1] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(+1, 0))
                {
                    matrix[currentbombRow + 1, currentBombCol] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(+1, -1))
                {
                    matrix[currentbombRow + 1, currentBombCol - 1] -= matrix[currentbombRow, currentBombCol];
                }
                if (isvalidCordinates(+1, +1))
                {
                    matrix[currentbombRow + 1, currentBombCol + 1] -= matrix[currentbombRow, currentBombCol];
                }
                 matrix[currentbombRow, currentBombCol] = 0;
            }
               
            }          
        }
        private static bool isvalidCordinates(int row,int col)
        {
            return row + currentbombRow >= 0 && row + currentbombRow < matrix.GetLength(0) && col + currentBombCol >= 0 && col + currentBombCol < matrix.GetLength(1)
                && matrix[row + currentbombRow, col + currentBombCol] > 0;
        }

        private static void InputElements()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
        }
    }
}
