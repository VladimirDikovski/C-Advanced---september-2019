using System;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] matrix;
        static int possiiontPlayerow;
        static int possiiontPlayecol;
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            matrix = new char[rows, cols];
            InputElements();
            string moves = Console.ReadLine();
            EscapeFromLair(moves);
       
        }

        private static void EscapeFromLair(string moves)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                char commnand = moves[i];
                if (commnand == 'L' && ISValid(possiiontPlayerow, possiiontPlayecol - 1) )
                {
                    matrix[possiiontPlayerow, possiiontPlayecol - 1] = matrix[possiiontPlayerow, possiiontPlayecol];
                    MovinagBunni();                 
                }
                if (commnand == 'R' && ISValid(possiiontPlayerow, possiiontPlayecol+1))
                {
                    matrix[possiiontPlayerow, possiiontPlayecol + 1] = matrix[possiiontPlayerow, possiiontPlayecol];
                    MovinagBunni();
                }
                if (commnand == 'U' && ISValid(possiiontPlayerow-1, possiiontPlayecol))
                {
                    matrix[possiiontPlayerow-1, possiiontPlayecol ] = matrix[possiiontPlayerow, possiiontPlayecol];
                    MovinagBunni();
                }
                if (commnand == 'D' && ISValid(possiiontPlayerow+1, possiiontPlayecol))
                {
                    matrix[possiiontPlayerow + 1, possiiontPlayecol] = matrix[possiiontPlayerow, possiiontPlayecol];
                    MovinagBunni();
                }
            }
        }

        private static void MovinagBunni()
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B' && ISValid(row - 1, col))
                    {
                        matrix[row - 1, col] = 'B';
                    }
                    if (matrix[row, col] == 'B' && ISValid(row + 1, col))
                    {
                        matrix[row + 1, col] = 'B';
                    }
                    if (matrix[row, col] == 'B' && ISValid(row, col + 1))
                    {
                        matrix[row, col + 1] = 'B';
                    }
                    if (matrix[row, col] == 'B' && ISValid(row, col - 1))
                    {
                        matrix[row, col - 1] = 'B';
                    }
                }
            }
            
        }

        private static bool ISValid(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && matrix[row, col] == '.' && matrix[row, col] !='B';
        }

        private static void InputElements()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                    if (matrix[row, col] == 'P')
                    {
                        possiiontPlayerow = row;
                        possiiontPlayecol = col;
                    }
                }
            }
        }
    }
}
