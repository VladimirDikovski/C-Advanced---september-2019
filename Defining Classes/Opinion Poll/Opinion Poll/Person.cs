using System;
using System.Collections.Generic;
using System.Text;


   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

       public Person(string name ,int age)
        {
            this.Name = name;
            this.Age = age;

        }
        public Person()
        {
            this.Name = "No Name";
            this.Age = 1;

        }
        public Person(int age) : this()
        {
            this.Age = age;
        }
    }

