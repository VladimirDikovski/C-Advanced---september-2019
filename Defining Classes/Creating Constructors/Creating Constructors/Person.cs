using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;

        }
        public Person(int year)
            :this()
        {
            this.Age = year;
        }

        public Person(string name ,int year)
        {
            this.Name = name;
            this.Age = year;
            
        }

    }
}
