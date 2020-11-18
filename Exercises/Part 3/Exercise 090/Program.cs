using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask user to enter name & age

      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] data = input.Split(",");
      }

      // Compare ages to print the age of the oldest 

      int oldest = Convert.ToInt32(data[1]);

      for (int i = 0; i < data.Count; i++)
      {
        int age =  data[i];
        if (oldest < age)
        {
          oldest = age;
        }
      }

      // If empty line, break + print age of the oldest

      Console.WriteLine("The age of the oldest is " + oldest);

    }
  }
}



