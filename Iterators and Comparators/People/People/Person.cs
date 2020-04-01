using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace People
{
   public class Person:IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
        public Person(string name,int age,string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
        }

        public int CompareTo([AllowNull] Person other)
        {
            int result = other.Age.CompareTo(this.Age);
            if (result == 0)
            {
                return 0;
            }
            return result;
            
        }
    }
}
