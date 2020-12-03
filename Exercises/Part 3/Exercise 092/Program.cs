using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int age = 0;
      int birthYear = 0;
      int oldest = 0;

      string name = "";
      string longestName = "";
      
      while (true)
      {    
        string input = Console.ReadLine();
        
        if (input != "")
        {
          string[] nameYOB = input.Split(',');

          name = nameYOB[0];
          birthYear = Convert.ToInt32(nameYOB[1]);
          age = 2020 - birthYear;

          if (age > oldest)
          {
              age = oldest;
          }

          if (name.Length > longestName.Length)
          {
            name = longestName;
          }
          else 
          {
            break;
          }
        }

      Console.WriteLine("The longest name is " + longestName);
      Console.WriteLine("The highest age is " + oldest);
      }
    }  
  }
}

// Hoooooly brain mayhem. Continue working on this baby girl!