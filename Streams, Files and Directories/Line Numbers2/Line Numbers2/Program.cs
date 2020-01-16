using System;
using System.Collections.Generic;
using System.IO;

namespace Line_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"..\..\..\..\text.txt");
            var writter = new StreamWriter(@"..\..\..\..\Output.txt");
            using (reader)
            {
                int counterLine = 1;
               
                using (writter)
                {

                    while (!reader.EndOfStream)
                    {
                        int counterWord = 0;
                        int counterSymbols = 0;
                        var read = reader.ReadLine();
                        foreach (var word in read)
                        {
                            if (char.IsLetter(word))
                            {
                                counterWord++;
                            }
                            if (char.IsPunctuation(word))
                            {
                                counterSymbols++;
                            }
                        }
                        writter.WriteLine($"Line {counterLine}: {read} ({counterWord}) ({counterSymbols})");
                        
                    }
                }                         
            }
        }
    }
}
