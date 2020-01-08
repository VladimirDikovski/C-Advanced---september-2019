using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var partysTime = new HashSet<string>();
            InputReservations(partysTime);
            Console.WriteLine(partysTime.Count);           
            foreach (var item in partysTime)
            {
                Console.WriteLine(item);
            }
        }

        private static void InputReservations(HashSet<string> partysTime)
        {
            string guests = Console.ReadLine();
            while (guests!="END")
            {              
                if (guests == "PARTY")
                {
                    while(true)
                    {
                        
                        if (guests == "END")
                        {
                            return;
                        }
                        guests = Console.ReadLine();
                        partysTime.Remove(guests);
                        
                    }
                }

                if (guests.Length == 8)
                {
                    if (!partysTime.Contains(guests))
                    {
                        partysTime.Add(guests);
                    }                   
                }
                guests = Console.ReadLine();
            }

           
        }
    }
}
