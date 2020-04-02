using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparing_Objects
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] splitedInput = input.Split(" ");
                string name = splitedInput[0];
                int age = int.Parse(splitedInput[1]);
                string town = splitedInput[2];
                Person personOne = new Person(name, age, town);
                persons.Add(personOne);

            }
            int nPersont = int.Parse(Console.ReadLine());
            Person ComplarePerson = persons[nPersont - 1];
            int maches = 0;
            foreach (var item in persons)
            {
                maches += item.CompareTo(ComplarePerson);
            }

            if (maches < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.Write($"{maches} {persons.Count-maches} {persons.Count}");
            }
          
            
        }
    }
}
