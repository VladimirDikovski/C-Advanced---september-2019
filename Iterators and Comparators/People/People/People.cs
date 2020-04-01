using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace People
{
   public class People: IEnumerable<Person>
    {
        private List<Person> Persons;

        public People()
        {
            Persons = new List<Person>();
        }

        public void AddMembers(Person person)
        {
            Persons.Add(person);
            Persons.Sort();
        }

      

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                yield return Persons[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
