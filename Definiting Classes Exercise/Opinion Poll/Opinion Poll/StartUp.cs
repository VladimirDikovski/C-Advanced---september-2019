using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int nCount = int.Parse(Console.ReadLine());
            var listOfPerson = new List<Person>();
            for (int i = 0; i < nCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                var newPerson = new Person(name, age);
                listOfPerson.Add(newPerson);
            }

            listOfPerson = listOfPerson.Where(x => x.Age >= 30).OrderBy(x=>x.Name).ToList();

            foreach (var item in listOfPerson)
            {
                Console.Write($"{item.Name} - {item.Age}");
                Console.WriteLine();
            }


        }

       
    }
}
