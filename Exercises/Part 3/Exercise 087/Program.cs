using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Give a string");
        string input = Console.ReadLine();

        if(input != "")
        {
          string[] pieces = input.Split(" "); 

          for(int i = 0; i < input.Length; i++)
          {
            if(input[i].Contains("av"))
            {
              Console.WriteLine(input[i]);
            } 
          }        
        }
      }
    }
  }
}