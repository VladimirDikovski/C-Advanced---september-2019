using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countArrays = int.Parse(Console.ReadLine());
            double[][] jaggedAray = new double[countArrays][];
            InputElements(jaggedAray);
            Analyzing(jaggedAray);
            ManiPulationArray(jaggedAray);
            PrintArrays(jaggedAray);


        }

        private static void PrintArrays(double[][] jaggedAray)
        {
            foreach (var item in jaggedAray)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }

        private static void ManiPulationArray(double[][] jaggedAray)
        {
            bool isValidcord = false;
            while (true)
            {
                string[] manipulationOperators = Console.ReadLine().Split(" ");
                string command = manipulationOperators[0];
                if (command == "End")
                {
                    break;
                }
                int currentAray = int.Parse(manipulationOperators[1]);
                int currentIndex = int.Parse(manipulationOperators[2]);
                int value = int.Parse(manipulationOperators[3]);
                isValidcord=isValidCordinats(currentAray, currentIndex, jaggedAray);
                if (!isValidcord)
                {
                    continue;
                }
                ÄddOrSubtractValue(jaggedAray, command, currentIndex, value,currentAray);

                
            }
        }

        private static void ÄddOrSubtractValue(double[][] jaggedAray, string command, int currentIndex, int value,int currentAray)
        {
            if (command == "Add")
            {
                jaggedAray[currentAray][currentIndex] += value;
            }
            else if(command== "Subtract")
            {
                jaggedAray[currentAray][currentIndex] -= value;
            }
        }

        private static bool isValidCordinats(int currentAray, int currentIndex, double[][] jaggedAray)
        {
            return currentAray >= 0 && currentAray < jaggedAray.Length && currentIndex >= 0 && currentIndex < jaggedAray[currentAray].Length;
        }

        private static void Analyzing(double[][] jaggedAray)
        {
            for (int arays = 0; arays < jaggedAray.Length-1; arays++)
            {
                if(jaggedAray[arays].Length == jaggedAray[arays + 1].Length)
                {
                    for (int i = 0; i < jaggedAray[arays].Length; i++)
                    {
                        jaggedAray[arays][i] *= 2;
                        jaggedAray[arays+1][i] *= 2;

                    }
                }
                else
                {
                    for (int i = 0; i < Math.Max(jaggedAray[arays].Length, jaggedAray[arays+1].Length); i++)
                    {
                        if (jaggedAray[arays].Length > i)
                        {
                            jaggedAray[arays][i] /= 2;
                        }
                        if(jaggedAray[arays+1].Length > i)
                        {
                            jaggedAray[arays + 1][i] /= 2;
                        }
                       
                    }
                }
            }
        }

        private static void InputElements(double[][] jaggedAray)
        {
            for (int arays = 0; arays < jaggedAray.Length; arays++)
            {
                jaggedAray[arays] = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            }
        }
    }
}
