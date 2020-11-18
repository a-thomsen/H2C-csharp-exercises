using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string");
      string input = Console.ReadLine();

      if (input == "true")
      {
        Console.WriteLine("You got it right!");
        break;
      }
      else
      {
        Console.WriteLine("Try again!");
      }
    }
  }
}

