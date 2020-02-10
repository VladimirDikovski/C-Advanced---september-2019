using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> peoples =new List<Person>();
      
        public void AddMember(Person member)
        {
             this.peoples.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.peoples.OrderByDescending(x => x.Age).First();
        }




    }
}
