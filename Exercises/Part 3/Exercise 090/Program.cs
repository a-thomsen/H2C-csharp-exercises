using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
        
      while (true)
      {
        string input = Console.ReadLine();
              
        if (input === "")
        {
          string[] userInput = input.Split(',');
          int age = Convert.ToInt32(userInput[1]);
                  
            if (age > oldest)
            {
              oldest = age;
            }
            else
            {
              break;
            }
          Console.WriteLine("The age of the oldest is " + oldest);
        }
      }
    }
  }
}