using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
   

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            using (var reader = new StreamReader("FileOne.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int read = int.Parse(reader.ReadLine());
                    list.Add(read);
                }            

            }
            using (var reader = new StreamReader("FileTwo.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int read = int.Parse(reader.ReadLine());
                    list.Add(read);
                }

            }
            list = list.OrderBy(x => x).ToList();

          using (var writter =new StreamWriter("Output.txt"))
            {
                foreach (var item in list)
                {
                    writter.WriteLine(item);
                }
            }
        }
    }
}
