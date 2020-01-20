using System;
using System.Collections.Generic;
using System.Linq;
namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(new char[] { ',', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToList();

            Func<double, double> Vat = x => x * 1.20;
            digits = digits.Select(Vat).ToList();
            foreach (var item in digits)
            {
                Console.WriteLine($"{item:F2}");
            }

        }
    }
}
