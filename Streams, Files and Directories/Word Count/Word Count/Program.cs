using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, int>();
            using (var currentWord = new StreamReader("words.txt"))
            { 
                var line = currentWord.ReadLine();
                string[] Words = line.Split(" ");
                String pattern = @"[a-zA-Z']+";
                Regex regex = new Regex(pattern);

                using (var text = new StreamReader("text.txt"))
                {
                    string curretText = text.ReadLine();
                    while (curretText != null)
                    {

                        foreach (Match match in regex.Matches(curretText))
                        {
                            for (int i = 0; i < Words.Length; i++)
                            {
                                if (match.Value.ToLower() == Words[i] && !(dict.ContainsKey(Words[i])))
                                {
                                    dict.Add(Words[i], 1);
                                }
                                else if (match.Value.ToLower() == Words[i])
                                {
                                    dict[Words[i]]++;
                                }
                            }

                        }
                        curretText = text.ReadLine();
                    }

                }

            }
            using (var writer = new StreamWriter("Output.txt"))
            {
                foreach (var item in dict.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} {item.Value}");
                }
            }

        }

    }
}
