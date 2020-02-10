using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var person = new Person();
            var family = new Family();


            for (int i = 0; i < n; i++)
            {
               var input = Console.ReadLine().Split();
               var name = input[0];
               var age = int.Parse(input[1]);
              person = new Person(name, age);
              family.AddMember(person);
            }

            var result = family.GetOldestMember();

            Console.Write($"{result.Name} {result.Age}");

            
        }
    }
}
