using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldestAge = 0;
      string oldestName = "";

      while (true)
      {
        string input = Console.ReadLine();
        
        if(input != "")
        {
          string[] userInput = input.Split(',');
          
          int age = Convert.ToInt32(userInput[1]);
          
          // Retrieve name of the oldest person

          if (age > oldestAge)
          {
            oldestName = nameAndAge[0];
          }
          else 
          {
            break;
          }
        }
      Console.WriteLine("The name of the oldest is " + oldestName);
    }
  }
}