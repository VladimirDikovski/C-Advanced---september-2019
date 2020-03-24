using System;
using System.Linq;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            var newFamily = new Family();
            int NPerson = int.Parse(Console.ReadLine());
            for (int i = 0; i < NPerson; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                var newPerson = new Person(name,age);
                newFamily.AddMembers(newPerson);
            }

            Person olderFamilt = newFamily.GetOldestMember();
            Console.WriteLine($"{olderFamilt.Name} {olderFamilt.Age}");
        
          
        }
    }
}
