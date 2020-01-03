using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] ChessBord = new char[size, size];
            InputElements(ChessBord);
            EliminateKnight(ChessBord);
           

        }

        private static void EliminateKnight(char[,] chessBord)
        {
            int countAtack = 0;        
            int atackRow = 0;
            int atackCol = 0;
            int countRevomesKnight = 0;
            while (true)
            {
                int maxAtack = 0;
               
                for (int row = 0; row < chessBord.GetLength(0); row++)
                {

                    for (int col = 0; col < chessBord.GetLength(1); col++)
                    {
                        if (chessBord[row, col] == 'K')
                        {
                            if (IsValidCordinates(chessBord, row - 2, col + 1) )
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row - 2, col - 1))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row - 1, col + 2))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row - 1, col - 2))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row + 1, col + 2))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row + 1, col - 2))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row + 2, col + 1))
                            {
                                countAtack++;
                            }
                            if (IsValidCordinates(chessBord, row + 2, col - 1))
                            {
                                countAtack++;
                            }
                        }
                        if (countAtack > maxAtack)
                        {
                            maxAtack = countAtack;
                            atackRow = row;
                            atackCol = col;

                        }
                        countAtack = 0;
                    }  
                }

                if (maxAtack > 0)
                {
                    chessBord[atackRow, atackCol] = '0';
                    countRevomesKnight++;
                }
                else
                {
                    break;
                }
              
            }
            Console.WriteLine(countRevomesKnight);
        }

        private static bool IsValidCordinates(char[,] chessBord,int row,int col )
        {
            return row >= 0 && row < chessBord.GetLength(0) && col >= 0 && col < chessBord.GetLength(0) && chessBord[row,col]=='K';
        }

        private static void InputElements(char[,] chessBord)
        {
            for (int row = 0; row < chessBord.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < chessBord.GetLength(1); col++)
                {
                    chessBord[row, col] = elements[col];
                }
            }
        }
    }
}
