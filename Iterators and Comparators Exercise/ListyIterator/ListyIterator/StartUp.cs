using System;
using System.Collections.Generic;

namespace ListyIterator
{
   public class StartUp
    {
      public  static void Main(string[] args)
        {
            List<string> currentElemnts = new List<string>();
            ListyIterator<string> digitsIterator = new ListyIterator<string>();
            while (true)
            {
                
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] spliteInput = input.Split(" ");
                string commnad = spliteInput[0];
                if (commnad == "Create")
                {
                   digitsIterator = new ListyIterator<string>(Create(spliteInput, currentElemnts));
                   
                }
                else if(commnad== "Move")
                {
                    Console.WriteLine(digitsIterator.Move());
                }
                else if(commnad== "HasNext")
                {
                    Console.WriteLine(digitsIterator.HasNext());
                }
                else if(commnad== "Print")
                {
                    
                    Console.WriteLine(digitsIterator.Print());
                }
              
            }
          
        }

        private static List<string> Create(string[] spliteInput, List<string> currentElemnts)
        {
            for (int i = 1; i < spliteInput.Length; i++)
            {
                currentElemnts.Add(spliteInput[i]);
            }
            return currentElemnts;
        }
    }
}
