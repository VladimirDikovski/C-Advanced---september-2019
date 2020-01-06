using System;
using System.Collections.Generic;
using System.Linq;
namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();
            AverageStudentGrades(n, dict);          
            PrintResult(dict);

        }

        private static void PrintResult(Dictionary<string, List<double>> dict)
        {
            foreach (var name in dict)
            {
                Console.WriteLine($"{name.Key} -> {string.Join(" ", name.Value.Select(x=>x.ToString("F2")))} (avg: {name.Value.OrderBy(x=>x).Average():F2})");
            }
        }


        private static void AverageStudentGrades(int n,Dictionary<string, List<double>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                   
                }
               
                    dict[name].Add(grade);
                

            }
                
        }
    }
}
