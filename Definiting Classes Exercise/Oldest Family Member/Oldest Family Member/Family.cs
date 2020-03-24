using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Oldest_Family_Member
{
   public  class Family
    {
        public List<Person> listOfPerson { get; set; } = new List<Person>();

        public void AddMembers(Person members)
        {
            listOfPerson.Add(members);
        }
        public Person GetOldestMember()
        {
            return listOfPerson.OrderByDescending(x => x.Age).First();
        } 
       
    }
}

   
