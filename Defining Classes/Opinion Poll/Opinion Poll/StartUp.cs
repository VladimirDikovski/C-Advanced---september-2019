using System;
using System.Collections.Generic;
using System.Linq;

  public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listofpeople = new List<Person>();
           
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name,age);
                listofpeople.Add(person);              
            }

            var result = listofpeople.Where(x => x.Age >= 30);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(Environment.NewLine,item.Name + " - "  +item.Age));
            }
             

           
        }
    }

