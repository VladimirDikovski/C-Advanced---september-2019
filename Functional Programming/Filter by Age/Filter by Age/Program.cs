using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        class Person
        {
            public string name { get; set;}
            public  int age { get; set;}
        }
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            var ListOFPeople = new List<Person>();
            PutPeopleInTheList(nPeople, ListOFPeople);
            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            Func<Person, bool> predicate = SortbyAge(condition,ageFilter);
            string format = Console.ReadLine();
            Func<Person, string> Predicate2 = SelectByFormat(format);
          ListOFPeople.Where(predicate).Select(Predicate2).ToList().ForEach(Console.WriteLine);

        }

        private static Func<Person, string> SelectByFormat(string format)
        {
            if (format == "name age")
            {
                return x => $"{x.name} - {x.age}";
            }
            else if (format == "name")
            {
                return x => $"{x.name}";
            }
            else if (format == "age")
            {
               return x => $"{x.age}";
            }
            else
            {
                return x => null;
            }
           
        }

        private static Func<Person, bool> SortbyAge(string condition, int ageFilter)
        {
            if (condition == "older")
            {
                return x => x.age >= ageFilter;
            }
            else
            {
                return x => x.age < ageFilter;
            }
            
        }

        private static void PutPeopleInTheList(int nPeople, List<Person> listOFPeople)
        {
            for (int i = 0; i < nPeople; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var People = new Person
                {
                    name = input[0],
                    age = int.Parse(input[1])
                };

                listOFPeople.Add(People);
               
            }
        }
    }
}
