using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("01. Odd Lines/Input.txt");

            using (reader)
            {
                using (var wrriter = new StreamWriter("Output.txt"))
                {
                    int counter = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 1)
                        {
                            wrriter.WriteLine(line);
                        }

                        counter++;
                    }
                }
              
                
            }
        }
    }
}
